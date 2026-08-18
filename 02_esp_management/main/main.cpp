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

DHT dht(DHT_PIN, DHT_TYPE);

void button_task(void *pvParameter)
{
    gpio_config_t led_io_conf = {
        .pin_bit_mask = (1ULL << LED_PIN),
        .mode = GPIO_MODE_OUTPUT,            // 출력 모드로 설정
        .pull_up_en = GPIO_PULLUP_DISABLE,
        .pull_down_en = GPIO_PULLDOWN_DISABLE,
        .intr_type = GPIO_INTR_DISABLE
    };
    // LED 핀 설정 적용
    gpio_config(&led_io_conf);

    // 버튼 핀 설정을 위한 구조체
    gpio_config_t btn_io_conf = {
        .pin_bit_mask = (1ULL << BUTTON_PIN), // 0번 핀 선택
        .mode = GPIO_MODE_INPUT,              // 입력 모드로 설정
        .pull_up_en = GPIO_PULLUP_ENABLE,     // 내부 풀업 저항 활성화
        .pull_down_en = GPIO_PULLDOWN_DISABLE,
        .intr_type = GPIO_INTR_DISABLE
    };
    // 버튼 핀 설정 적용
    gpio_config(&btn_io_conf);

    printf("GPIO configuration complete. Starting button task...\n");

    while(1)
    {
        int button_state = gpio_get_level(BUTTON_PIN);
        if (button_state == 0)      // 버튼 눌렸을 때
        {
            gpio_set_level(LED_PIN, 1);     // LED 키기
        }
        else
        {
            gpio_set_level(LED_PIN, 0);
        }
        vTaskDelay(10 / portTICK_PERIOD_MS);        // 10 ms 대기
    }
}

void dht_task(void *pvParameter)
{
    Serial.println("DHT11 Task start");

    while(1) {
        float humidity = dht.readHumidity();
        float temperature = dht.readTemperature();

        if(isnan(humidity) || isnan(temperature)) {
            Serial.println("DHT11 failed");
        } else {
            Serial.printf("humidity %.1f%%, temperature : %.1f\n", humidity, temperature);
        }
    }
}

void setup()
{
    Serial.begin(115200);
    Serial.println("Initializing system..\n");

    dht.begin();
    xTaskCreate(&button_task, "Button Task", 2048, NULL, 5, NULL);
    xTaskCreate(&dht_task, "DHT Task", 2048, NULL, 3, NULL);

    Serial.println("Button Task running\n");
    Serial.println("DHT Task running\n");
}
