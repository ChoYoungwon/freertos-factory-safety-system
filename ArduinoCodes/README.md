### FourByForeKeyPad (키패드)
- 16개의 스위치 회로가 행열로 배치

### IRremote (IR 리모컨)
- 적외선 사용(리모컨, 적외선 수신기)
- IRremote (ver. 2.6.0) - IRrecvDumpV2 예제 파일 사용

### JoyStick (조이스틱)
- 내부의 가변저항이 있어 x축과 y축의 데이터를 읽어올 수 있음
- 조이스틱 방향에 따라 출력하고, LED 불을 제어

### arduino_basic (언어 문법)
- 아두이노 연산 테스트
- 시리얼 입출력 테스트
- LED 제어

### ball_switch (볼 스위치)
- ball 스위치 제어 (작은 공이 들어있어 평소에는 연결되어 있다가 기울이게되면 공이 굴러가 스위치가 off 되는 제품)

### fnd (Flexible Numeric Display)
- 애노드 공통타입 (공통단자 : 5V, 단자에는 LOW 신호)
- 공통 캐소드 (공통단자 : GND, 단자에는 HIGH 신호)

### humidity_sensor (온습도 센서)
- DHT11 온습도 센서 모듈
- DFRobot_DHT11라이브러리 사용

### photoresistor (조도 센서)
- 황화카드뮴(cds)을 소재로 만든 cds 센서
- 빛이 밝을수록 전도율이 높아져 저항이 낮아지고, 어두울수록 전도율이 낮아져서 저항이 높아진다

### rgb_led (RGB LED 모듈)
- 빛의 3원색 이용 LED 색 제어

### tact_switch (택트 스위치)
- 택트 스위치 제어 (버튼식 스위치)
- 스위치1 누를시 LED 점등, count 증가, 스위치2 누를시 LED 점등, count 감소

### temperature_sensor (온도센서)
- LM35, VCC(1), OUTPUT(2), GND(3)으로 구성
- 온도가 1도 올라갈 때마다 10mV씩 전압이 증가함
- 온도 = (5.0 x lLM35 출력값 x 100) / 1024.0

### variable_resistor (가변 저항)
- 가변 저항 제어
- map(변환할 수, 현재 범위의 하한값, 현재 범위의 상한값, 목표 범위의 하한 값, 목표 범위의 상한값)
