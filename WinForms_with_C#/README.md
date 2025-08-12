### DBconn.cs  
- 생성자 : `DBconn()` 또는 `DBconn(ip, port, database, userid, password)`  
- `public void MadangDbConn()` : madangDB 연결 파라미터 적용  
- `public MySqlConnection SetConnection()` : 데이터베이스 연결
  
### From1.cs  
<img width="632" height="428" alt="image" src="https://github.com/user-attachments/assets/dd51de49-c615-4003-9381-64f11c7180be" />  
  
- customer 테이블 조회, 행 삽입, 수정, 삭제 기능  
- ListView 사용
  
### From2.cs  
<img width="702" height="442" alt="image" src="https://github.com/user-attachments/assets/5a583f21-6e40-4bc7-8aa7-40acccf104f3" />  
  
- 주문관리 조회 기능  
- orders, book, custoerm 조인 -> 손님 이름, 책 이름 표시  
- ListView 사용  
  
### From3.cs  
<img width="376" height="413" alt="image" src="https://github.com/user-attachments/assets/fb0305de-69e2-4ec8-a046-6941f7b4dbe9" />  
  
- 회원가입 기능  
- 파라미터 방식 사용(sql 인젝션 공격 방지)  
- 비밀번호 생성시 -> 솔트 생성(16바이트 크기의 무작위 암호학적 안전한 난수), 솔트 + 비밀번호 -> SHA256 통해 암호화  
  
### From4.cs  
<img width="310" height="368" alt="image" src="https://github.com/user-attachments/assets/56a23b52-3ea4-4626-aca2-7671e427de19" />  
  
- 로그인 기능  
- 파라비터 방식 사용  
- 비밀번호 생성 과정과 동일하게 해시처리 -> 바이트 배열을 비교하여 로그인 성공 여부 판별  
  
### From5.cs  
<img width="679" height="477" alt="image" src="https://github.com/user-attachments/assets/40c03ce0-e8b5-48c2-aa23-a225f9869776" />  
  
- NuGet관리에서 WinForms.DataVisualization 설치  
- 타이머를 이용해 랜덤 값 그래프로 시각화  
- 데이터베이스에 랜덤 값을 저장(insert)  
  
