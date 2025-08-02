#include <Stepper.h>

const int steps = 2048;       // 모터의 스텝수 2048=1바퀴, 1024=반바퀴
Stepper myStepper(steps, 11, 9, 10, 8);
int val = 0;
void setup() {
  myStepper.setSpeed(10);     // 1분에 10번의 회전, 1회전은 60/10 회전이 되므로 6초가 걸리게 된다.
  Serial.begin(9600);
}

// 회전할 때 6도씩 회전하여 60번 멈춰야하는데 0도에서 6도까지 가는데 걸리는 시간은 6초 / 60 = 0.1 이므로
// 0도에서 6도까지 0.1초가 걸린다.
// delay를 사용해 0.9초를 대기하여 1초를 맞춰준다.
void loop() {
  Serial.println("시계방향");
  val = map(1,0,60,0,steps);
  myStepper.step(val);
  delay(900);
}