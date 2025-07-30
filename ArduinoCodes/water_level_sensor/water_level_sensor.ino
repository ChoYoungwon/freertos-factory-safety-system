/* 
  수분 수위감지 센서는 '토양 수분감지 센서', '빗방울 감지센서' 원리와 동일
  몰탱크나 수조와 같이 물이 담긴 용기의 수위를 측정하는데 이용할 수 있음
  세로로 위치한 전극 부분은 수위에 따라 저항값이 변하고, 이에 따라 전류값도 변하게 됨.
*/

// 수분량이 증가 -> 수위 높아지면 -> 저항 감소, 전류 증가
// 수분량 감소 -> 수위 감소 -> 저항 증가, 전류 감소

int water_pin = A5;      
void setup() {
  Serial.begin(9600);
}

void loop(){
  int val = analogRead(A5);   // 수분수위센서값을 'val'에 저장 
  Serial.println(val);       // 센서값을 시리얼 모니터로 출력
  delay(100);
}

// 수위 센서의 값 변화에 따른 LED 조절
// int water_pin = A5;      //수분수위센서 A5에 연결
// int LED1 = 2;            // LED를 각각 디지털핀 2,3,4에 연결
// int LED2 = 3;
// int LED3 = 4;

// void setup() {
//   Serial.begin(9600);    
//   pinMode( 2,   OUTPUT);  // 디지털핀 2,3,4를 출력으로 설정
//   pinMode( 3,   OUTPUT);
//   pinMode( 4,   OUTPUT);
// }

// void loop(){
//   int val = analogRead(A5);   // 수분수위센서값을 'val'에 저장 
//   Serial.println(val);       // 센서값을 시리얼 모니터로 출력
//   delay(100);                 
  
//   if(val <= 400){              // 센서값이 400 이하면 모든 LED OFF
//     digitalWrite( 2, LOW);
//     digitalWrite( 3, LOW);
//     digitalWrite( 4, LOW);
//     delay(100);
//   }
//    else if( 400 < val && val <= 680 ){   // 400 < 센서값 ≤500 이면 빨간 LED ON
//     digitalWrite( 2, HIGH);
//     digitalWrite( 3, LOW);
//     digitalWrite( 4, LOW);          
//     delay(100);
//   }
//    else if( 680 < val && val <= 730){   // 680< 센서값 ≤730 이면 빨,노 LED ON
//     digitalWrite( 2, HIGH);          
//     digitalWrite( 3, HIGH);
//     digitalWrite( 4, LOW);            
//     delay(100);
//   }
//    else {                                // 센서값 > 730 이면 빨,노,파 LED ON
//     digitalWrite( 2, HIGH);
//     digitalWrite( 3, HIGH);
//     digitalWrite( 4, HIGH);
//     delay(100);                       
//   }
// }