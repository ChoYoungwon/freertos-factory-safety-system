### AGauge 컨트롤
- 원래는 NuGet설정에서 다운 -> 호환성 문제로 AGauge github의 cs 파일 다운로드해서 적용
1. 버튼 클릭시 `aGauge1.Value +=5;`를 이용해 값 증가
2. Button 클래스를 상속 받아 CircularButton를 생성(동그란 버튼) -> 특정 값 변화시 색상 및 텍스트 변화
3. 타이머를 이용해 이미지 회전
4. FormProgress Bar, 타이머 이용(연속적인 바 : Blocks, Continuous / Marquee 스타일)
  - 기본적인 속성은 Maximum (기본값 100), Minimum (기본값 0), Step (기본값 10), Value (기본값 0) 등
  - Step은 진행 간격을 의미하며, Value는 현재 진행 값이다. 따라서 기본값만을 이용할 경우 총 10단계의 진행 간격을 갖게 된다.
<img width="792" height="482" alt="image" src="https://github.com/user-attachments/assets/4943e3e3-ecfd-4a7f-89db-8c316d740990" />
