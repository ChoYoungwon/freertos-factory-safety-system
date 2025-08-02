// 온도센서(LM35), 온도 = (5.0 x LM35 출력값 x 100) / 1024.0
void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  int temp = analogRead(A0);
  int value = 5.0*temp*100.0/1024;
  Serial.print(value);
  Serial.println("C");
  delay(1000);
}
