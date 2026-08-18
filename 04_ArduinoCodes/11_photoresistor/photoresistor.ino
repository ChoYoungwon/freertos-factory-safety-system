int led = 12;
// 조도센서 사용(황화카드뮴), 빛의 양이 많을 수록 저항이 낮아지고, 
// 빛의 양이 적을 수록 저항이 커진다

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(led,OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  int val = analogRead(A1);
  Serial.println(val);

  if(val < 512) {
    digitalWrite(led, HIGH);
  } else {
    digitalWrite(led, LOW);
  }

  delay(100);
}
