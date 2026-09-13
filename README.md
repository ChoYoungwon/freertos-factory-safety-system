## FreeRTOS 기반 실시간 보장 안전 제어 시스템   
### 1. 수행 기간  
2025.08.9. ~ 2025.08.14  (Update: 2026.08.28 ~ 2026.08.31)

### 2. 프로젝트 개요  
1. 목적  
 FreeRTOS 운영체제를 적용하여 긴급 중지 버튼이 장비의 작동을 중지시키는 것을 보장하고  
 화재와 같은 긴급 상황 발생 시 센서를 통해 감지하고 즉각적으로 경고를 발생시킨다.   
 평상시는 설비 상태를 안정적으로 모니터링할 수 있는 태스크 우선순위 기반 안전 제어 시스템을 구축하는 것을 목표한다.  
2. 개발환경  
ESP32-DevKitC V4 개발보드 (ESP32-WROOM-32E 모듈 기반, 32bit dual-core @240MHz, 2.4GHz, 520KB SRAM(16 KB for cache), 448 KB  
ROM)/ VsCode(PlatformIO) / MySQL / WinForm(.NET 8.0) / Visual Studio / Window 11 Home intel Core i5 프로세서, 8GB RAM  
3. 주요 기능   
   - 회원가입, 로그인 후 시스템 접근 가능  
   - 우선순위 기반 설비 제어 
     (1: 장비 긴급 중지 / 2: 화재 발생 / 3: 온ㆍ습도 모니터링)    
   - 그래프와 수치를 통한 온도 및 습도 모니터링(2s 주기)  
   - 시스템 긴급 중지(택트 스위치)시 : LED 점등, GUI - 시스템 비동작 여부 알림, 설비 동작 중단    
   - 화재 발생시 : GUI – 화재 발생 여부 알림, LED 점등  
   - 동작 재개 요청시 : 동작 재개 가능
4. 사용 기술  
   - C언어 기반 ESP32 마이크로컨트롤러 제어  
   - FreeRTOS 커널 기반 멀티테스크 구현  
   - WinForms(C#) 기반 상태 모니터링 및 동작 제어 윈도우 애플리케이션 개발  
   - ESP32 MCU와 윈도우 애플리케이션(PC) Serial(UART)통신  
   - MySQL을 이용한 사용자 관리용 데이터베이스 구축 
### 3. 구성도  
<img width="701" height="433" alt="시스템 아키텍처 다이어그램 drawio" src="https://github.com/user-attachments/assets/59880cf6-5115-40ea-b1f2-ac9d4878137b" />  

### 4. 파일 개요
1. **프로젝트 파일**  
   - `00_safety_management_UI` : ESP32와 상호작용하는 Windows Application (WinForms)
     - Form1 (메인 화면, GUI 및 동작 제어)  
     - Form3 (회원 가입)  
     - Form4 (로그인)  
   - `01_esp32_platformIO` : VsCode의 platformIO 사용해 작업(src -> main.cpp)  
      - 기존 아두이노 방식을 사용(아두이노의 라이브러리 사용 가능)
2. 관련 예제 파일  
   - `02_esp_management` : ESP-IDF 사용 (완성 X)   
   - `03_arduino` : FreeRTOS 라이브러리, 예제  
   - `04_ArduinoCodes` :  아두이노 예제  
   - `05_sensor_interface1` : SerialPort 상호작용을 이용한 윈폼에서의 아두이노 제어
   - `06_SQL` : SQL 예제 및 문법 정리  
   - `07_SmartFactory_SW/ArduinoCodes`: Arduino IDE Sketchbook location 
### 5. 프로젝트 결과  
#### GUI  
Main  
<img width="701" height="433" alt="main1" src="https://github.com/user-attachments/assets/da50922e-09ee-4959-9419-63e86ccdbc59" />
  
#### Flame 감지 작동 모습  
<img width="701" height="433" alt="flame2" src="https://github.com/user-attachments/assets/61e62127-3fad-4a0b-af50-96788d5dc36a" />  
  
#### 하드웨어 구현 모습  
<img width="701" height="433" alt="flame2" src="https://github.com/user-attachments/assets/eab0c1c9-a1de-44b6-9518-db74f2150e6f" />  

### 6. 결과 분석
#### [자세한 내용 (클릭)](./01_esp32_platformIO/README.md)
* **아두이노 블로킹**: 다른 센서의 블로킹 딜레이(2초)에 안전장치가 종속되어 **약 1.4초의 정지 지연**과 높은 비결정성(지터 324.83 ms)을 보입니다.
* **RTOS 폴링**: 멀티태스킹 격리를 통해 온습도 딜레이와 무관하게 **20ms 이내(평균 8.99 ms)로 설비 및 타 태스크를 정지**시키는 결정성을 확보하였습니다. (아두이노 대비 99.35% 응답 개선).
* **RTOS 인터럽트+선점**: 하드웨어 인터럽트와 Task Notification 선점 기법, 그리고 임계구역을 조합하여 폴링 대기마저 소거함으로써 **단 0.12 ms (122 마이크로초) 만에 완벽한 안전 정지**를 구현하였습니다. (아두이노 대비 99.99% 단축, 11,409배 반응 속도 향상).
* **자원 소모량**: Flash 용량 증가는 단 **+0.25%**, RAM 증가는 단 **8 Byte**에 불과하여, **극소의 자원 오버헤드로 극한의 실시간 안전 신뢰성을 구현**할 수 있음을 확인하였습니다.

### 10. 프로그램 실행 방법
#### 1) ESP32 업로드
1. `01_esp32_platformIO/src/main.cpp` 코드가 ESP32 MCU에 탑재되는 방식
2. `visual studio code` -> PlatformIO 실행 -> 하단에 `→(업로드)` 선택
3. **Serial Terminal** 열람시 **전기 플러그(🔌) 아이콘** 선택 (Serial.println으로 출력하는 데이터를 확인할 수 있다.)
4. ESP32의 EN버튼 클릭시 리셋(재부팅) 기능을 수행한다.
#### 2) UI 실행
1. `00_safety_management_UI/safety_management.sln` 실행
2. `Build` -> `Build Solution` 클릭
3. `00_safety_management_UI\safety_management\bin\Debug\net8.0-windows\safety_management.exe` 실행
4. 또는 Visual Studio에서 `Ctrl + F5`로 실행
5. 회원가입 -> 로그인 -> COM5(컴퓨터와 연결된 포트 - 장비관리자 확인) Serial 연결 진행

### 11. SmartFactory_SW 구현 교육 과정  
1. C# 기본 문법 공부  
2. WinFormsApp 구현  
3. Arduino 이용한 하드웨어 센서 제어  
4. WinFormsApp과 Serial Port를 이용한 아두이노 제어  
5. WinFormsApp과 MySQL을 이용한 데이터베이스 제어  
6. WPF 개요 및 간단한 예제 학습  
7. 프로젝트 진행 

### 12. 참조  
- https://esp32io.com/ (esp32 튜토리얼 및 센서 인터페이싱 예제)  
- https://www.coupang.com/vp/products/8757170787?vendorItemId=92529413015&sourceType=MyCoupang_my_orders_list_product_title (ESP32 개발보드 구매처)  
- https://tutoduino.fr/en/discover-freertos-on-an-esp32-with-platformio/#google_vignette (ESP32 freeRTOS 개발 환경 구축, PlatformIO 사용 방법)  
- 정소미, 「화학공정산업의 스마트 팩토리 안전관리 시스템 구축에 관한 연구 아시아대학교 공학대학원, 2019  
- 최선영, 「스마트 안전관리 시스템」, 『현장기술소개』, 쌍용건설, pp. 94-97.
