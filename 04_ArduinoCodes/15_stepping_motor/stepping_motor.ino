#include <Stepper.h>

const int steps = 2048;

Stepper myStepper(steps, 11, 9, 10, 8);

void setup() {
  // put your setup code here, to run once:
  myStepper.setSpeed(15);
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
    Serial.println("시계방향");
    myStepper.step(steps);
    delay(500);

    Serial.println("반시계방향");
    myStepper.step(-steps);
    delay(500);
}
