int led = 3;
int ball = 5;

// ball스위치 : 작은 공이 들어있어 평소에는 연결되어 있다가 기울이게되면 
// 공이 굴러가 스위치가 off 되는 제품

void setup() {
  Serial.begin(9600);
  // put your setup code here, to run once:
  pinMode(led, OUTPUT);
  pinMode(ball, INPUT_PULLUP);
}

void loop() {
  Serial.println(digitalRead(ball));
  if(digitalRead(ball)) {      // 평소에는 led off
    digitalWrite(led, LOW);
  } else {                      // ball switch가 기울어지면 led on
    digitalWrite(led, HIGH);
  }
  delay(100);
}
