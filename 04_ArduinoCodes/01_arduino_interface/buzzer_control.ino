// int buzzer = 5; //버저를 핀 5번에 연결
// //'도레미파솔라시도' 음계 주파수 배열로 선언
// int melody[] = {262, 294, 330, 349, 392, 440, 494, 523};
// String receivedStr = "";
// int val;
// void setup()
// {
// 	Serial.begin(9600);
// 	pinMode(buzzer, OUTPUT);
// }

// void loop()
// {
// 	if(Serial.available())
// 	{
// 		  receivedStr = Serial.readStringUntil('\n');
// 			val = receivedStr.toInt(); 
// 			Serial.println(val);
// 			tone(buzzer,val,400); // 0.4초동안 음계 출력
// 			delay(500); //0.5초 대기
// 	}
// 	else
// 	{
// 		noTone(5); //베에조 버저 OFF
// 	}
// }