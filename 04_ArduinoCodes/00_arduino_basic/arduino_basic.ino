int led_pin = 3;
void setup() {
  Serial.begin(9600);

  // 1. 아두이노 연산
  // SerialCalculations();  

  pinMode(led_pin, OUTPUT);
}

void loop() {

  // 2. 시리얼 입출력
  // SerialIf();

  // 3. LED 제어
  LED_ON_OFF();
}
