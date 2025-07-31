// int LED_1 = 9;
// int LED_2 = 10;
// int LED_3 = 11;
// int receiveNum = 0;

// void setup() {
//   Serial.begin(9600);
//   pinMode(LED_1,OUTPUT);
//   pinMode(LED_2,OUTPUT);
//   pinMode(LED_3,OUTPUT);

//   if(Serial.available())
//   {
//     Serial.println(receiveNum);
//   }
// }

// void loop() {
//   if(Serial.available())
//   {
//     receiveNum = Serial.read();
//     Serial.println(receiveNum);
    
//     if(receiveNum == 48)
//     {
//       digitalWrite(LED_1, LOW);
//       digitalWrite(LED_2, LOW);
//       digitalWrite(LED_3, LOW);
//     }
//     else if(receiveNum == 49)
//     {
//       digitalWrite(LED_1, HIGH);
//       digitalWrite(LED_2, LOW);
//       digitalWrite(LED_3, LOW);
//     }
//     else if(receiveNum == 50)
//     {
//       digitalWrite(LED_1, LOW);
//       digitalWrite(LED_2, HIGH);
//       digitalWrite(LED_3, LOW);
//     }
//     else if(receiveNum == 51)
//     {
//       digitalWrite(LED_1, LOW);
//       digitalWrite(LED_2, LOW);
//       digitalWrite(LED_3, HIGH);
//     }
//   }
// }
