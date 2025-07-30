
int buzzer = 5; //버저를 핀 5번에 연결
int sw = 4; // 스위치를 핀 4번에 연결

//'도레미파솔라시도' 음계 주파수 배열로 선언
int melody[] = {262, 294, 330, 349, 392, 440, 494, 523};

// damper[] = { , ,} -> 연주 유지시간을 배열로 선언

// 부저 - 피에조 효과를 이용해 공기를 진동시켜 소리를 만들어 낸다.
// 능동 부저(전원 연결만 해도 내부 특정 주파수에 의해 소리가 발생) - 다리 길이가 다른 경우가 많음
// 수동 부저(내장된 회로가 없어서 주파수를 발생시켜 입력해주어야 함) - 다리 길이가 같은 경우가 많음

void setup()
{
	pinMode(buzzer, OUTPUT);
	pinMode(sw, INPUT_PULLUP);
}

void loop()
{
	if(digitalRead(sw)==0)
	{
		for(int a=0; a<8; a++)
		{
			tone(buzzer,melody[a],400); // 0.4초동안 음계 출력
			delay(200); //0.5초 대기
		}
	}
	else
	{
		noTone(5); //베에조 버저 OFF
	}
}