int led_pin = 3;
int switch_pin = 5;
int switch_pin2 = 7;
int count = 0;

void setup() {
  Serial.begin(9600);
  pinMode(switch_pin, INPUT_PULLUP);
  pinMode(switch_pin2, INPUT_PULLUP);
  pinMode(led_pin, OUTPUT);
} 

// 스위치1 누를시 LED 점등, count 증가, 스위치2 누를시 LED 점등, count 감소
void loop() {
  if (digitalRead(switch_pin) == LOW) {
    Serial.println(++count);
    // Serial.println(digitalRead(swtich_pin));
    digitalWrite(led_pin, HIGH);
  } 
  else if (digitalRead(switch_pin2) == LOW) {
    Serial.println(--count);
    digitalWrite(led_pin, HIGH);
  } 
  else {
    digitalWrite(led_pin, LOW);
  }
  delay(250);
}
