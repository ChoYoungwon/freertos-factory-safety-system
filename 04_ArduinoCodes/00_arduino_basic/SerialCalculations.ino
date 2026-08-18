// 아두이노 연산 테스트
void SerialCalculations() {
  int a = 7;
  int b = -5;
  int ab = a + b;

  Serial.println("ab");
  Serial.println(ab);
  Serial.println(a-b);
  Serial.println(a*b);
  Serial.println(a/b);
}

// 시리얼 입출력 테스트
void SerialIf() {
  char a = '1';
  char b = '0';
  if (Serial.available()) {
    b = Serial.read();
    Serial.println(b);
    if (a == b) {
      Serial.println("Hello World");
    } else {
      Serial.println("Hello");
    }
  }
}

// LED 제어하기
void LED_ON_OFF() {

  char a = '0';
  if(Serial.available()) {
    a = Serial.read();

    if (a == '1') {
      digitalWrite(led_pin, HIGH);
      delay(500);
      digitalWrite(led_pin, LOW);
      delay(500);
    } 
    else if (a == '2') {
      for (int i = 0; i < 2; i++) {
        digitalWrite(led_pin, HIGH);
        delay(500);
        digitalWrite(led_pin, LOW);
        delay(500);
      }
    } 
  }
}
