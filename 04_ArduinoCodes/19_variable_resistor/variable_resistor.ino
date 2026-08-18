int AnalogPin = A5;
int LedPin = 3;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(LedPin, OUTPUT);
}

void loop() {
  // val에 가변 저항 값을 저장
  int val = analogRead(AnalogPin);
  Serial.println(val);

  // map(변환할 수, 현재 범위의 하한값, 현재 범위의 상한값, 목표 범위의 하한 값, 목표 범위의 상한값)
  val = map(val, 0, 1023, 0, 255);

  // 반환된 값을 LED로 출력
  analogWrite(LedPin, val);
}
