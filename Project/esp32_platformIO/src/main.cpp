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

DHT dht(DHT_PIN, DHT_TYPE);

bool stop_flag = false;
bool flame_flag = false;
int flame_count = 0;

void button_task(void *pvParameter)
{
  Serial.println("Button Task start");

  while(1) {
    int buttonState = digitalRead(BUTTON_PIN);

    if (buttonState == LOW && stop_flag == false) {
      stop_flag = true;
      Serial.println("emergency_stop");
    } 

    if (Serial.available()) {
      String command = Serial.readStringUntil('\n');
      command.trim();
      Serial.println(command);
      if (command == "recover") {
        stop_flag = false;
      }
      
      if (command == "stop") {
        stop_flag = true;
      }
    }

    if (stop_flag == true) {
      digitalWrite(LED_PIN, HIGH);
    } else {
      digitalWrite(LED_PIN, LOW);
    }
    // Serial.println(stop_flag);
    vTaskDelay(20 / portTICK_PERIOD_MS);
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
      Serial.printf("%.1f,%.1f\n", humidity, temperature);
    }

    vTaskDelay(2000 / portTICK_PERIOD_MS);    // 2초마다 센서 값 읽기
  }
}

void flame_task(void *pvParameter) {
  Serial.println("Flame Task start");
  while(1) {
    int infrared_value = analogRead(FLAME_PIN);

    if (infrared_value < 4000 && flame_flag == false) {
      Serial.println("flame");
      stop_flag = true;
      flame_flag = true;
    }

    if (infrared_value == 4095 && flame_flag == true) {
      flame_count++;
    }

    if (infrared_value == 4095 && flame_count > 10) {
      flame_flag = false;
      flame_count = 0;
      Serial.println("noflame");
    }

    vTaskDelay(500 / portTICK_PERIOD_MS); // 0.5초마다 센서값 읽기
  }
}

void setup()
{
    Serial.begin(115200);
    Serial.println("Initializing system..\n");

    pinMode(LED_PIN, OUTPUT);
    pinMode(BUTTON_PIN, INPUT_PULLUP);
    analogSetAttenuation(ADC_11db);

    dht.begin();
    
    xTaskCreate(&flame_task, "Flame Task", 2048, NULL, 5, NULL);
    xTaskCreate(&button_task, "Button Task", 2048, NULL, 7, NULL);
    xTaskCreate(&dht_task, "DHT Task", 2048, NULL, 3, NULL);

    Serial.println("Button Task running\n");
    Serial.println("DHT Task running\n");
}

void loop() {

}
