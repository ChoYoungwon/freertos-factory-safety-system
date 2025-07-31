## Form1 (LED ON/OFF, 메인 화면)  
<img width="627" height="380" alt="image" src="https://github.com/user-attachments/assets/84a71dc2-06b7-4510-b9a9-445351bec1bf" />  
- 아두이노에서 해당 코드를 업로드 한 이후 실행  
- 아두이노 코드 : `arduino_interface.ino`  
- `SerialPort port = new SerialPort("COM5", 9600);`로 연결  
- `port.Open(), port.Write(), port.Close()`  
  
## Form2 (Port 연결, 데이터 수신)  
<img width="330" height="353" alt="image" src="https://github.com/user-attachments/assets/210b7f95-9ea5-4fdd-a888-1b5185757057" />  
- 아두이노 코드 : `serial_recieve.ino`  
- 연결가능한 포트를 보여주고, 선택 후 연결  
- `serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);`  
- 이벤트 핸들러를 이용해 시리얼 데이터를 읽는다. 
- UI를 동적으로 업데이트 하기 위해 함수(Action)를 만들어서 메인 쓰레드에 맡긴다. (Invoke)  
- Windows의 텍스트 줄바꿈 표준은 \r\n  
  
## Form3(시리얼 데이터 LCD에 전송)  
<img width="349" height="314" alt="image" src="https://github.com/user-attachments/assets/724afbea-59c7-49db-94b0-3d0331304283" />  
- 아두이노 코드 : `LCD_send.ino`  
- `serialPort1.Write(sendData);`를 이용해 LCD에 전송  
  
## Form4(RGB 모듈 제어)  
<img width="658" height="351" alt="image" src="https://github.com/user-attachments/assets/bfb297a9-cdff-4e2f-84ba-1b4241a577fd" />  
- 아두이노 코드 : `RGB_control.ino`  
- Form2를 상속해 구현  
- 버튼을 눌렀을 때 0~3까지의 숫자가 순차적으로 전송 -> 해당하는 색의 빛 켜짐  
  
## Form5(조이스틱으로 GUI 움직이기)  
<img width="651" height="318" alt="image" src="https://github.com/user-attachments/assets/e2362911-671c-432f-954f-0a4f20dcb422" />
- 아두이노 코드 : `Joystic_control.ino`  
- 객체의 Top, Left 값을 속도로 빼주면서 이동(키보드로 이동 + 조이스틱 이동)  
- 조이스틱에서의 상하좌우의 값을 읽어와서 객체를 이용  
- 키를 누르고 있는 동안 계속 움직이게 하기 위해 타이머를 이용  
  
## Form6(조도 센서 GUI로 표현)  
<img width="661" height="364" alt="image" src="https://github.com/user-attachments/assets/8eca62d6-54cf-4092-b1ab-1f3344c2943f" />  
- 아두이노 코드 : `Photoresistor_control.ino`  
- Form4를 상속해 구현  
- 트랙바를 움직이면 R, G의 값이 커져 노란색으로 바뀌어감  
- 조도센서의 값을 읽어와 255에 빼줌으로써 gui의 밝기가 변화함  
  
## Form7(GUI에서 모터 조정)  
<img width="543" height="272" alt="image" src="https://github.com/user-attachments/assets/3e371590-c431-4da1-9609-9d90ba34907b" />  
- 아두이노 코드 : `servomotor_control.ino`  
- Form3를 상속받음  
- btn_send_Click이 실행될 수 있도록 자식 메서드에 override, 부모 메서드에 virtual을 추가  
- 10 이상의 숫자가 잘리므로 아래와 같이 설정  
- `receivedStr = Serial.readStringUntil('\n');`  
- `val = receivedStr.toInt();`  
- 아두이노가 \n을 기다리므로 \n을 추가  
