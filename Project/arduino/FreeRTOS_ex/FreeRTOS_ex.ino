// // #include <FreeRTOS_AVR.h>
// // #include <basic_io_avr.h>

// // #include <FreeRTOS_AVR.h>
// // #include <basic_io_avr.h>

// /**
//  * FreeRTOS 최소 기능 테스트 (Bare Minimum)
//  * - Serial 통신을 포함한 모든 부가 기능을 제거하고,
//  * 오직 하나의 Task만으로 LED를 제어하여 RTOS의
//  * 핵심 스케줄러 동작 여부만을 확인합니다.
//  */
// #include <Arduino_FreeRTOS.h>

// // Task 함수 프로토타입 선언
// void TaskBlink(void *pvParameters);

// void setup() {
//   // 시리얼 통신을 사용하지 않습니다.

//   // configMINIMAL_STACK_SIZE는 FreeRTOS가 정의한
//   // 가장 기본적인 Task를 위한 최소 스택 크기입니다.
//   // 이보다 더 줄일 수는 없습니다.
//   xTaskCreate(
//     TaskBlink,
//     "Blink",
//     configMINIMAL_STACK_SIZE, // 가장 작은 스택 크기 사용
//     NULL,
//     1,             // 우선순위
//     NULL
//   );
// }

// void loop() {
//   // 스케줄러가 실행되므로 비워둡니다.
// }

// void TaskBlink(void *pvParameters) {
  
//   (void) pvParameters;
//   pinMode(8, OUTPUT);

//   for (;;) {
//     digitalWrite(8, HIGH);
//     vTaskDelay(500 / portTICK_PERIOD_MS); // 0.5초 켜기

//     digitalWrite(8, LOW);
//     vTaskDelay(500 / portTICK_PERIOD_MS); // 0.5초 끄기
//   }
// }


void setup() {
  // pinMode(2, OUTPUT);
}

void loop() {
  // digitalWrite(2, HIGH);
  // delay(1000);
  // digitalWrite(2, LOW);
  // delay(1000);
}




