#include <Keypad.h>

const byte ROWS = 4;
const byte COLS = 4;
char  myKeys[ROWS][COLS]=
{
  {'0','1','2','3'},
	{'4','5','6','7'},
	{'8','8','A','B'},
	{'C','D','E','F'}
};

byte rowPins[ROWS] = {5, 4, 3, 2};
//행(ROW)가 연결된 아두이노 핀 번호
byte colPins[COLS] = {8, 9, 10, 11};
//열(column)가 연결된 아두이노 핀 번호

Keypad customKeypad = Keypad(makeKeymap(myKeys),rowPins,colPins,ROWS,COLS);
//KeyPad 객체 인스턴화 

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600); //통신속도 9600으로 시리얼 통신 시작
}

void loop() {
  // put your main code here, to run repeatedly:
  char customKey = customKeypad.getKey();
	if(customKey)
	{
		Serial.println(customKey);
	}
}
