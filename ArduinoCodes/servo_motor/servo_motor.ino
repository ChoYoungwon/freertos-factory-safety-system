#include <Servo.h>

// 사용자가 원하는 속도나 각도를 지정해주면 그대로 동작하는 모터
// 서보모터 출력단에 토그가 많이 필요하게 되면 부하에 따라 높은 전류를 요구한다.
// usb로 전원 공급시 5V 핀에서 최대 500mA 출력이 가능, 
// 9V 이상의 외부전원 공급 시 최대 800mA의 전류를 출력할 수 있다.

Servo myservo;

int potentionmeter = A0; //가변저항 AO에 연결
int val; 

void setup()
{
	Serial.begin(9600);
	myservo.attach(9);       //서보모터 9번핀에 연결
}

void loop()
{
	val = analogRead(potentionmeter); 
	//가변저항에서 읽은 아날로그 값을 변수 val에 저장
	
	//map 함수를 이용해 아날로그 값 0~1023을 0~180으로 조정한 후 val에 저장
	val = map(val, 0, 1023, 0, 180);
	myservo.write(val); //val 값에 따라 서보모터 이동
	Serial.println(val);
	delay(15); //서보모터가 움직일 시간 15ms 딜레이
}