#include <IRremote.h>

int RECV_PIN = 2;
int led = 12;

IRrecv irrecv(RECV_PIN);
decode_results results;

// IRremote(ver. 2.6.0 사용)
// 파장이 길어서 눈에 보이지 않는 빛, TV, 에어컨 가전기기의 원격 제어용으로 사용

void setup() 
{
  pinMode(led, OUTPUT);
  Serial.begin(9600);
  irrecv.enableIRIn();
}

void loop() 
{
  if (irrecv.decode(&results))
  {
    Serial.println(results.value, HEX);
    digitalWrite(led, HIGH);
    delay(1000);                    
    digitalWrite(led, LOW);
    irrecv.resume();
  }

}