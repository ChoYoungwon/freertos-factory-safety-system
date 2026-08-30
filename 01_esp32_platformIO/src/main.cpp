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
volatile bool button_pressed = false;
volatile unsigned long last_interrupt_time = 0;
volatile unsigned long t_press = 0;

void command_task(void *pvParameter);

// 비상 정지 감지 Task
// 1. 버튼 인터럽트 서비스 루틴 (하드웨어 선점)
void IRAM_ATTR button_isr()
{
  unsigned long current_time = millis();
  if (current_time - last_interrupt_time > 250) { // 250ms 디바운스
    button_pressed = true;
    t_press = micros(); // 시작 시간 기록 
    last_interrupt_time = current_time;
  }
}

// 온습도 감지 Task
void dht_task(void *pvParameter)
{
  Serial.println("DHT11 Task start");
  while(1) {
    // 정지 상태일 때 dht Task를 종료시킨다.
    if (stop_flag == true) {
      Serial.println("DHT11 Task End by emergency stop");
      vTaskDelete(NULL);
    }
    // 화염 상태일 때 dht Task를 종료시킨다.
    if (flame_flag == true) {
      Serial.println("DHT11 Task End by flame");
      vTaskDelete(NULL);
    }
    float humidity = dht.readHumidity();
    float temperature = dht.readTemperature();

    if(isnan(humidity) || isnan(temperature)) {
      Serial.println("DHT11 failed");
    } else {
      Serial.printf("%.1f,%.1f\n", humidity, temperature);
    }

    UBaseType_t stack_margin = uxTaskGetStackHighWaterMark(NULL); 
    uint32_t free_heap = ESP.getFreeHeap();
    Serial.printf("[DHT Task] Stack Margin: %d bytes | System Free Heap: %d bytes\n", stack_margin, free_heap);

    vTaskDelay(2000 / portTICK_PERIOD_MS);    // 2초마다 센서 값 읽기
  }
}

// 화재 감지 Task
// void flame_task(void *pvParameter) {
//   Serial.println("Flame Task start");
//   int lastFlameState = HIGH;
//   int flame_count = 0;
//   while(1) {
//     // 정지 상태일 때는 Task를 종료시킨다.
//     if (stop_flag == true) {
//       Serial.println("Flame Task End by emergency stop");
//       vTaskDelete(NULL);
//     }
//     int infrared_value = analogRead(FLAME_PIN);

//     if (infrared_value < 4000 && flame_flag == false) {
//       Serial.println("flame");
//       flame_flag = true;
//     }

//     if (infrared_value == 4095 && flame_flag == true) {
//       flame_count++;
//     }

//     if (infrared_value == 4095 && flame_count > 50) {
//       flame_flag = false;
//       flame_count = 0;
//       Serial.println("noflame");

//       // 멈추었던 dht task를 다시 실행한다.
//       xTaskCreate(&dht_task, "DHT Task", 2048, NULL, 5, NULL);
//     }

//     vTaskDelay(200 / portTICK_PERIOD_MS); // 0.2초마다 센서값 읽기
//   }
// }

// 화재 감지 Task Test버전 (버튼으로 구현)
void flame_task_test(void *pvParameter){
  Serial.println("flame Task start");
  int lastFlameState = HIGH;
  int flame_count = 0;

  while(1) {
    // 정지 상태시 Task를 종료시킨다.
    if (stop_flag == true) {
      Serial.println("Flame Task End by emergency stop");
      vTaskDelete(NULL);
    }
    int FlameState = digitalRead(FLAME_TEST_PIN);

    // 엣지만 감지 (HIGH -> LOW로 바뀌는 순간만 포착)
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

      // 멈추었던 dht task를 다시 실행한다.
      xTaskCreate(&dht_task, "DHT Task", 2048, NULL, 5, NULL);
    }

    vTaskDelay(200 / portTICK_PERIOD_MS); // 0.2초마다 센서값 읽기
  }
}


// 설비 재개 감지 코드
// 시리얼 및 인터럽트 명령 처리 태스크
void command_task(void *pvParameter) {
  while (1) {
    // 1. 물리 버튼 인터럽트 발생 처리
    if (button_pressed) {
      button_pressed = false;
      if (stop_flag == false) {
        stop_flag = true;
        Serial.println("emergency_stop");
        digitalWrite(LED_PIN, HIGH);

        unsigned long t_led = micros(); // 완료 시간 기록
        float latency_ms = (t_led - t_press) / 1000.0;
        Serial.printf("[RTOS Interrupt+Task] Button Latency: %.3f ms\n", latency_ms);
        
        UBaseType_t stack_margin = uxTaskGetStackHighWaterMark(NULL); 
        uint32_t free_heap = ESP.getFreeHeap();
        Serial.printf("[DHT Task] Stack Margin: %d bytes | System Free Heap: %d bytes\n", stack_margin, free_heap);
      }
    }

    // 2. 시리얼 명령어 처리 (UI 연동)
    if (Serial.available()) {
      String command = Serial.readStringUntil('\n');
      command.trim();
      Serial.println(command); // 에코백

      if (command == "stop") {
        if (stop_flag == false) {
          stop_flag = true;
          Serial.println("emergency_stop");
          digitalWrite(LED_PIN, HIGH);
        }
      }
      else if (command == "recover") {
        if (stop_flag == true) {
          stop_flag = false;
          digitalWrite(LED_PIN, LOW);
          
          // 센서 및 기능 태스크 재동작
          xTaskCreate(&flame_task_test, "Flame Task", 2048, NULL, 7, NULL);
          xTaskCreate(&dht_task, "DHT Task", 2048, NULL, 5, NULL);
        }
      }
    }

    vTaskDelay(20 / portTICK_PERIOD_MS); // 20ms 마다 검사
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
    
    // Falling Edge 인터럽트 등록 (HIGH -> LOW 누름 시 트리거)
    attachInterrupt(digitalPinToInterrupt(BUTTON_PIN), button_isr, FALLING);

    // 태스크 생성 (명령어 처리 태스크 추가)
    xTaskCreate(&command_task, "Command Task", 2048, NULL, 8, NULL);
    xTaskCreate(&flame_task_test, "Flame Task", 2048, NULL, 7, NULL);
    xTaskCreate(&dht_task, "DHT Task", 2048, NULL, 5, NULL);
}

void loop() {

}
