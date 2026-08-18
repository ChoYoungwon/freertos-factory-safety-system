// 조이스틱을 이용한 상,하,좌,우 판단
// 해당 방향의 LED 점등
int sw=7;
int xValue = 0;
int yValue = 0;

int top_led = 3;
int bottom_led = 4;
int left_led = 5;
int right_led = 6;


void setup()
{
	Serial.begin(9600);
	pinMode(sw, INPUT_PULLUP);
	pinMode(top_led, OUTPUT);
	pinMode(right_led, OUTPUT);
	pinMode(left_led, OUTPUT);
	pinMode(bottom_led, OUTPUT);
	delay(1000);
}

void loop()
{
	Serial.print("X축:");
	Serial.print(analogRead(A0)); //X축 값 출력
	Serial.print("\t");
	Serial.print("Y축:");
	Serial.print(analogRead(A1)); //Y축 값 출력
	Serial.print("\n");
	Serial.print("스위치:");
	Serial.print(digitalRead(sw));
	Serial.print("\n");

	xValue = analogRead(A0);
	yValue = analogRead(A1);

	if( xValue <= 550 && xValue >= 516 && yValue == 521)
	{
		Serial.print("중앙\t");
	}

	if(xValue > 550)
	{
		Serial.print("좌\t");
		digitalWrite(left_led, HIGH);
		digitalWrite(bottom_led, LOW);
		digitalWrite(right_led, LOW);
		digitalWrite(top_led, LOW);
	}	
	else if(xValue < 450)
	{
		Serial.print("우\t");
		digitalWrite(right_led, HIGH);
		digitalWrite(bottom_led, LOW);
		digitalWrite(left_led, LOW);
		digitalWrite(top_led, LOW);
	}
	
	if(yValue > 600)
	{
		Serial.println("상");
		digitalWrite(top_led, HIGH);
		digitalWrite(bottom_led, LOW);
		digitalWrite(right_led, LOW);
		digitalWrite(left_led, LOW);
	}	
	else if(yValue < 450)
	{
		Serial.println("하");
		digitalWrite(bottom_led, HIGH);
		digitalWrite(right_led, LOW);
		digitalWrite(left_led, LOW);
		digitalWrite(top_led, LOW);
	}

	delay(500);
}