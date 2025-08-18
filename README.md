### SmartFactory_SW 구현 과정 개요  
1. C# 기본 문법 공부  
2. WinFormsApp 구현  
3. Arduino 이용한 하드웨어 센서 제어  
4. WinFormsApp과 Serial Port를 이용한 아두이노 제어  
5. WinFormsApp과 MySQL을 이용한 데이터베이스 제어  
6. WPF 개요 및 간단한 예제 학습  
7. 프로젝트 진행  
  
### 프로젝트 주제 : 실시간 안전 관리 시스템   
#### 수행 기간  
2025.08.11. ~ 2025.08.13  
#### 담당 역할  
프로젝트 주제 선정 및 구현  
ESP32(RTOS) 기반 온ㆍ습도 및 화재 감지, 비상 정지 구현 시스템 제작  
사용자 관리용 데이터베이스 구축 (MySQL)  
Winform(C#) 기반 상태 모니터링 및 동작 제어 GUI 프로그램 개발  
#### 수행목표  
1. RTOS를 이용한 실시간성 및 즉각적인 비상 정지 기능 보장 (우선순위 기반)  
2. 화재 감지 시(Flame 센서) 실시간 알림 기능 구현  
3. 평시 안정적인 설비 운영을 위한 온, 습도 모니터링 기능 구현  
4. 윈도우 애플리케이션을 이용한 센서 인터페이스 제어 기능 구현  
5. 로그인 및 회원가입 기본적인 기능 구현  
#### 사용 기술  
- C언어 기반 ESP32 마이크로컨트롤러 제어  
- FreeRTOS 커널 기반 멀티테스크 구현  
- Winform(C#) 기반 윈도우 애플리케이션 개발  
- ESP32 MCU와 윈도우 애플리케이션(PC) Serial(UART)통신  
- MySQL을 이용한 사용자 정보 저장 후 사용  
#### 구성도  
<img width="701" height="433" alt="시스템 아키텍처 다이어그램 drawio" src="https://github.com/user-attachments/assets/59880cf6-5115-40ea-b1f2-ac9d4878137b" />  
  
#### 상세 내용  
1. 목적  
 RTOS 운영체제를 적용하여 화재와 같은 긴급 상황 발생 시 즉각적으로 경고를   
발생하고 장비 작동을 중지시키는 것을 보장함, 평상시는 설비 상태를 안정적으로   
모니터링할 수 있는 태스크 우선순위 기반 안전 관리 시스템을 구축하는 것을  
목표로 함  
  
2. 개발환경  
ESP32-DevKitC V4 개발보드 (ESP32-WROOM-32E 모듈 기반, 32bit dual-core @240MHz, 2.4GHz, 520KB SRAM(16 KB for cache), 448 KB  
ROM)/ VsCode(PlatformIO) / MySQL / WinForm(.NET 8.0) / Visual Studio / Window 11 Home intel Core i5 프로세서, 8GB RAM  
  
5. 주요 기능   
- 회원가입, 로그인 후 시스템 접근 가능  
- 우선순위 기반 실시간 데이터 처리 기능  
  (1: 장비 긴급 중지, 2: 화재 발생, 3: 온ㆍ습도 모니터링  
- 그래프와 수치를 통한 온도 및 습도 모니터링(2s 주기)  
- 시스템 긴급 중지(택트 스위치)시 : LED 점등, GUI - 시스템 비동작 여부 알림  
- 화재 발생시 : GUI – 화재 발생, 시스템 비동작 여부 알림, LED 점등  
- 동작 재개 요청 : 화재 상태가 아닌 경우 동작 재개 가능  
#### 프로젝트 결과물  
##### GUI  
Main  
<img width="1031" height="590" alt="main1" src="https://github.com/user-attachments/assets/da50922e-09ee-4959-9419-63e86ccdbc59" />
  
Flame감지 작동 모습  
<img width="1031" height="586" alt="flame2" src="https://github.com/user-attachments/assets/61e62127-3fad-4a0b-af50-96788d5dc36a" />  
  
##### 하드웨어 구현 모습  
![hardware_image](https://github.com/user-attachments/assets/eab0c1c9-a1de-44b6-9518-db74f2150e6f)  
  
#### 참조  
- https://esp32io.com/ (esp32 튜토리얼 및 센서 인터페이싱 예제)  
- https://www.coupang.com/vp/products/8757170787?vendorItemId=92529413015&sourceType=MyCoupang_my_orders_list_product_title (ESP32 개발보드 구매처)  
- https://tutoduino.fr/en/discover-freertos-on-an-esp32-with-platformio/#google_vignette (ESP32 freeRTOS 개발 환경 구축, PlatformIO 사용 방법)  
-  정소미, 「화학공정산업의 스마트 팩토리 안전관리 시스템 구축에 관한 연구 아시아대학교 공학대학원, 2019  
- 최선영, 「스마트 안전관리 시스템」, 『현장기술소개』, 쌍용건설, pp. 94-97.   
    
### 레포지터리 하위 구조   
.  
├── ./`AGauge2 (게이지(Gauge) 컨트롤)`  
├── ./`Agauge (게이지 .cs 라이브러리 파일)`  
├── ./`ArduinoCodes (아두이노 예제)`  
├── ./`C#_study (C# 문법 공부)`  
├── ./`Project (실시간 안전관리 시스템 프로젝트)`  
├── ./`SQL (SQL 예제 및 문법 정리)`  
├── ./`SmartFactory_SW/ArduinoCodes (Arduino IDE Sketchbook location)`  
├── ./`WPFapplication (WPF 간단한 예제, 연습)`  
├── ./`WinFormsApp1 (기본적인 윈폼)`  
└── ./`WinFormsApp2 (윈폼 차트)`  
├── ./`WinForms_with_C# (윈폼과 MySQL 연결)`  
├── ./`sensor_interface1 (SerialPort 상호작용을 이용한 윈폼에서의 아두이노 제어)`  
  

