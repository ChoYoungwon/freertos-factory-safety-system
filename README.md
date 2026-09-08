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

#### 가. 응답시간 성능 고찰
* **아두이노 (동작의 비결정성)**  
  - 다른 센서 처리 블로킹 함수(`delay()`) 길이에 따라 안전 버튼의 지연 시간이 비례하여 증가하므로, **실시간성이 요구되는 시스템에 치명적**입니다. 
  - 폴링 방식으로 구현 시 **delay 시간 동안 버튼 클릭 자체가 누락되는 현상**이 발생하여 신뢰성에 큰 위협이 됩니다.
* **RTOS 폴링 (결정성 확보)**  
  - 멀티태스킹 스케줄링을 통해 온습도 딜레이와 무관한 균일한 반응성(20ms 내외)을 확보하였습니다. 
  - 매 주기 레지스터를 조회하므로 자원 소모가 발생합니다. 
  - (버튼 누름은 100~300ms 동안 유지되므로 20ms 주기 폴링 시 누락은 없으나, 지터/레이턴시가 주기 시간만큼 존재함)
* **RTOS 인터럽트 (실시간성 및 효율성 극대화)**  
  - 하드웨어 인터럽트로 이벤트 시점을 즉각 기록하고 플래그 기반으로 20ms 주기로 감시하여 가장 빠른 응답 속도와 자원 효율을 제공합니다. 
  - (하드웨어가 엣지를 즉시 검출하여 **1마이크로초 미만의 매우 짧은 입력도 100% 포착 가능합니다.**)
##### 전체 응답시간 비교 요약 (일반 상태 기준)
- **아두이노**: **평균 1,295.01 ms** (최대 1,876.41 ms 지연)
- **RTOS 폴링**: **평균 14.35 ms** (아두이노 대비 응답 시간 **98.89%** 감소, 약 **90.2배** 빨라짐)
- **RTOS 인터럽트**: **평균 10.42 ms** (아두이노 대비 응답 시간 **99.20%** 감소, 약 **124.3배** 빨라짐)

#### 나. 자원 소모량 결과 고찰
- **메모리(Flash/SRAM)**:
  - FreeRTOS를 적용한 버전들은 커널 및 태스크 할당으로 인해 기본 아두이노 버전 대비 **정적 메모리(Flash) 소모량이 약 0.15% 미만**으로 **아주 작게 증가**하였습니다.
  - 런타임 가용 힙 메모리는 약 **7,300 Byte 감소(감소율 전체 가용 메모리의 약 2.08% ~ 2.09% 수준)**에 불과합니다.
- **CPU 및 전력 효율**
  - 메모리 소모는 매우 소폭 증가했으나, `vTaskDelay`를 통한 적극적인 **CPU 양보 모델과 인터럽트를 통한 레지스터 접근 최소화 설계는 MCU의 활성 연산 시간을 감소**시킵니다. 
  - 최종적으로 시스템 수명 연장과 발열 감소 등 하드웨어 자원 효율성에서 훨씬 우수한 결과를 도출합니다.

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
