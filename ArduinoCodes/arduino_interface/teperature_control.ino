#include <DFRobot_DHT11.h>
DFRobot_DHT11 DHT;
#define DHT11_PIN 5

void setup(){
  Serial.begin(9600);
}

void loop(){
  DHT.read(DHT11_PIN);
  Serial.print(DHT.temperature);
  Serial.print(",");
  Serial.print(DHT.humidity);
  Serial.println("");
  delay(100);
}