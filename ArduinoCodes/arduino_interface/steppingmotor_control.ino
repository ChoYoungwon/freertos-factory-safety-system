// #include <Stepper.h>


// const int steps = 2048;
// Stepper myStepper(steps, 11, 9, 10, 8);
// int val = 0;
// void setup() {
//   myStepper.setSpeed(10);
//   Serial.begin(9600);
// }

// void loop() {
//   String receivedStr = "";
//   if(Serial.available())
//   {
//     receivedStr = Serial.readStringUntil('\n');
//     val = receivedStr.toInt();
//     Serial.println(val);
//     myStepper.step(val);
//   }
//   val = 0;
//   delay(300);
// }