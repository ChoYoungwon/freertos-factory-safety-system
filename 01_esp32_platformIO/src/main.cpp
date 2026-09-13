#include <stdio.h>
#include <freertos/FreeRTOS.h>
#include <freertos/task.h>
#include <driver/gpio.h>

#include <Arduino.h>
#include <DHT.h>

#define BUTTON_PIN 0
#define LED_PIN 2
#define DHT_PIN 4
#define DHT_TYPE DHT11
#define FLAME_PIN 34
#define FLAME_TEST_PIN 32

DHT dht(DHT_PIN, DHT_TYPE);

volatile bool stop_flag = false;
bool flame_flag = false;
volatile unsigned long last_interrupt_time = 0;
volatile unsigned long t_press = 0;
TaskHandle_t dht_task_handle = NULL;
TaskHandle_t flame_task_handle = NULL;

// FreeRTOS 태스크 핸들 및 임계구역 뮤텍스(Spinlock) 선언
TaskHandle_t emergency_task_handle = NULL;
portMUX_TYPE emergency_mux = portMUX_INITIALIZER_UNLOCKED;

void emergency_task(void *pvParameter);
void command_task(void *pvParameter);
void dht_task(void *pvParameter);
void flame_task_test(void *pvParameter);

// 비상 정지 감지 ISR (최우선순위 하드웨어 인터럽트)
void IRAM_ATTR button_isr()
{
  unsigned long current_time = millis();
  if (current_time - last_interrupt_time > 250) { // 250ms 디바운스
    t_press = micros(); // 시작 시간 기록 
    last_interrupt_time = current_time;

    // Task Notification을 통해 즉각 emergency_task를 깨우고 선점(Preemption) 요청
    BaseType_t xHigherPriorityTaskWoken = pdFALSE;
    vTaskNotifyGiveFromISR(emergency_task_handle, &xHigherPriorityTaskWoken);
    if (xHigherPriorityTaskWoken == pdTRUE) {
      portYIELD_FROM_ISR(); // 즉시 문맥 교환(Context Switch) 발생 (태스크 선점)
    }
  }
}

// 비상 정지 전담 태스크 (우선순위 10 - 최상위)
// 20ms 주기 폴링 없이 blocked 상태로 대기하다가 ISR에 의해 즉시 선점되어 실행됨
void emergency_task(void *pvParameter)
{
  while (1) {
    // 인터럽트 발생 시까지 무한 대기 (CPU 점유율 0%, 폴링 없음)
    ulTaskNotifyTake(pdTRUE, portMAX_DELAY);

    // [임계구역(Critical Section) 진입]
    // 인터럽트 및 타 코어 태스크의 간섭을 완전히 차단하여 원자적(Atomic)으로 비상 정지 및 핀 제어 실행
    portENTER_CRITICAL(&emergency_mux);
    if (stop_flag == false) {
      stop_flag = true;
      digitalWrite(LED_PIN, HIGH); // 설비 즉각 정지 (LED 점등)
    }
    portEXIT_CRITICAL(&emergency_mux);
    // [임계구역 탈출 - 블로킹 I/O 및 태스크 삭제는 임계구역 밖에서 안전하게 수행]

    if (flame_task_handle != NULL) {
      vTaskDelete(flame_task_handle);
      flame_task_handle = NULL;
      Serial.println("Flame Task Killed immediately!");
    }

    if (dht_task_handle != NULL) {
      vTaskDelete(dht_task_handle);
      dht_task_handle = NULL;
      Serial.println("DHT Task Killed immediately!");
    }

    unsigned long t_led = micros(); // 모든 태스크 정지 완료 시간 기록
    float latency_ms = (t_led - t_press) / 1000.0;

    Serial.println("emergency_stop");
    Serial.printf("[RTOS Interrupt+Preemption] Button Latency: %.3f ms\n", latency_ms);

    UBaseType_t stack_margin = uxTaskGetStackHighWaterMark(NULL); 
    uint32_t free_heap = ESP.getFreeHeap();
    Serial.printf("[Emergency Task] Stack Margin: %d bytes | System Free Heap: %d bytes\n", stack_margin, free_heap);
  }
}

// 온습도 감지 Task (우선순위 5)
void dht_task(void *pvParameter)
{
  Serial.println("DHT11 Task start");
  while (1) {
    if (stop_flag == true) {
      Serial.println("DHT11 Task End by emergency stop");
      dht_task_handle = NULL;
      vTaskDelete(NULL);
    }
    if (flame_flag == true) {
      Serial.println("DHT11 Task End by flame");
      dht_task_handle = NULL;
      vTaskDelete(NULL);
    }
    float humidity = dht.readHumidity();
    float temperature = dht.readTemperature();

    if (isnan(humidity) || isnan(temperature)) {
      Serial.println("DHT11 failed");
    } else {
      Serial.printf("%.1f,%.1f\n", humidity, temperature);
    }

    UBaseType_t stack_margin = uxTaskGetStackHighWaterMark(NULL); 
    uint32_t free_heap = ESP.getFreeHeap();
    Serial.printf("[DHT Task] Stack Margin: %d bytes | System Free Heap: %d bytes\n", stack_margin, free_heap);

    vTaskDelay(2000 / portTICK_PERIOD_MS); // 2초마다 센서 값 읽기
  }
}

// 화재 감지 Task Test버전 (버튼으로 구현) (우선순위 7)
void flame_task_test(void *pvParameter)
{
  Serial.println("flame Task start");
  int lastFlameState = HIGH;
  int flame_count = 0;

  while (1) {
    if (stop_flag == true) {
      Serial.println("Flame Task End by emergency stop");
      flame_task_handle = NULL;
      vTaskDelete(NULL);
    }
    int FlameState = digitalRead(FLAME_TEST_PIN);

    if (lastFlameState == HIGH && FlameState == LOW) {
      flame_flag = true;
      Serial.println("flame");
    }
    lastFlameState = FlameState; 

    if (flame_flag) flame_count++;

    if (flame_flag == true && flame_count > 50) {
      flame_flag = false;
      flame_count = 0;
      Serial.println("noflame");

      // dht_task 재생성 시 반드시 &dht_task_handle 전달하여 포인터 갱신
      if (dht_task_handle == NULL) {
        xTaskCreate(&dht_task, "DHT Task", 2048, NULL, 5, &dht_task_handle);
      }
    }

    vTaskDelay(200 / portTICK_PERIOD_MS); // 0.2초마다 센서값 읽기
  }
}

// 시리얼 명령 처리 태스크 (UI 연동) (우선순위 8)
void command_task(void *pvParameter)
{
  while (1) {
    if (Serial.available()) {
      String command = Serial.readStringUntil('\n');
      command.trim();
      Serial.println(command); // 에코백

      if (command == "stop") {
        portENTER_CRITICAL(&emergency_mux);
        if (stop_flag == false) {
          stop_flag = true;
          digitalWrite(LED_PIN, HIGH);
        }
        portEXIT_CRITICAL(&emergency_mux);

        if (flame_task_handle != NULL) {
          vTaskDelete(flame_task_handle);
          flame_task_handle = NULL;
        }
        if (dht_task_handle != NULL) {
          vTaskDelete(dht_task_handle);
          dht_task_handle = NULL;
        }

        Serial.println("emergency_stop");
      }
      else if (command == "recover") {
        if (stop_flag == true) {
          portENTER_CRITICAL(&emergency_mux);
          stop_flag = false;
          digitalWrite(LED_PIN, LOW);
          portEXIT_CRITICAL(&emergency_mux);
          
          if (flame_task_handle == NULL) {
            xTaskCreate(&flame_task_test, "Flame Task", 2048, NULL, 7, &flame_task_handle);
          }
          if (dht_task_handle == NULL) {
            xTaskCreate(&dht_task, "DHT Task", 2048, NULL, 5, &dht_task_handle);
          }
        }
      }
    }

    vTaskDelay(20 / portTICK_PERIOD_MS); // 시리얼 수신 대기 주기
  }
}

void setup()
{
    Serial.begin(115200);
    Serial.println("Initializing system..\n");

    pinMode(LED_PIN, OUTPUT);
    pinMode(BUTTON_PIN, INPUT_PULLUP);
    pinMode(FLAME_TEST_PIN, INPUT_PULLUP);
    analogSetAttenuation(ADC_11db);
    dht.begin();
    
    // 긴급 정지 전담 태스크 생성 (우선순위 10 - 최상위 부여)
    xTaskCreate(&emergency_task, "Emergency Task", 2048, NULL, 10, &emergency_task_handle);

    // Falling Edge 인터럽트 등록 (버튼 누름 시 트리거)
    attachInterrupt(digitalPinToInterrupt(BUTTON_PIN), button_isr, FALLING);

    // 일반 기능 태스크 생성
    xTaskCreate(&command_task, "Command Task", 2048, NULL, 8, NULL);
    xTaskCreate(&flame_task_test, "Flame Task", 2048, NULL, 7, &flame_task_handle);
    xTaskCreate(&dht_task, "DHT Task", 2048, NULL, 5, &dht_task_handle);
}

void loop()
{
}
