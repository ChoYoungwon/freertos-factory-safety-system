#include <LiquidCrystal_I2C.h>
#include <Wire.h>
 
 // set the LCD address to 0x27 for a 16 chars and 2 line display
LiquidCrystal_I2C lcd(0x27,16,2); 
 
 
void setup()
{
  lcd.init();  // LCD초기 설정             
  lcd.backlight(); // LCD초기 설정  
  lcd.setCursor(0,0); //텍스트가 LCD에 나타날 위치
  lcd.print("Hellow, world!"); 
  lcd.setCursor(3,1);
  lcd.print("How are you?"); 
}

void loop()
{
  
}