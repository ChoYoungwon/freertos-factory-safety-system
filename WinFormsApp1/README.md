### WinFormsApp 구현
(윈폼 : 윈도우 응용프로그램을 빠르고 손쉽게 개발하기 위한 API 세트)

#### Form1
- 메인 화면 구성
- newForm.Show()로 창 생성
- 첫번째 입력창 : 숫자만 입력 가능(e.Handled = true) 
<img width="413" height="532" alt="image" src="https://github.com/user-attachments/assets/3a25024f-8d9e-402a-bae3-43c542ab289b" />


#### Form2(Button Control)
<img width="399" height="437" alt="image" src="https://github.com/user-attachments/assets/f9bdaf61-b242-47ff-9dc7-8c27d21ba2bc" />

#### Form3(CheckBox Control)
- 선택한 항목 보기 클릭시 선택항목 메시지 박스로 표현
- 라디오버튼 체크시 라벨.Visible = true로 설정하여 표시
- 리스트 박스 이용(Form_Load에서 초기화)
- 콤보박스(드롭 다운, 드롭다운리스트, 심플) - Form_Load에서 초기화(combo.Items.AddRange(배열))
<img width="649" height="500" alt="image" src="https://github.com/user-attachments/assets/f7f89351-fb8b-4450-8f57-68a8cb845296" />

#### Form4(Timer Control)
- timer.Interval = 1000 (1초 단위로 시간 증가)
<img width="250" height="204" alt="image" src="https://github.com/user-attachments/assets/b520593c-6367-44c6-bd53-45cee61384f2" />

#### Form5(DataGrid View)
- Bounding 모드 vs UnBounding 모드(개발자가 직접)
- 테이블 형태의 데이터를 화면에 출력
<img width="531" height="331" alt="image" src="https://github.com/user-attachments/assets/ae1545bd-1bb1-45ee-9ce7-68f27abaa622" />

#### Form6(Calculator)
- 계산기 제작
- 숫자 표시 레이블 : Dock : top, AutoSize: False 설정
- 버튼 클릭으로 값 계산 제어
<img width="390" height="537" alt="image" src="https://github.com/user-attachments/assets/fadd7d2c-ec26-4afa-bc8b-ccde59f87340" />

### Form7(입력을 받아서 파일에 쓰기)
- 텍스트 파일 쓰는 경우 : 하단참고
- `StreamWriter wr = new StreamWriter("data.txt", true);`
- `wr.WriteLine(data);`
- `wr.Close();`
<img width="378" height="420" alt="image" src="https://github.com/user-attachments/assets/f82861d4-79af-4cc9-a6a4-90d5be26cf65" />

### Form8(텍스트 파일 데이터 가져오기)
- Load Data 클릭시 : data.txt 파일에서 데이터를 가져와 출력
- `StreamReader rd = new StreamReader("data.txt");`
```
while(!rd.EndOfStream)
{
    string line = rd.ReadLine();
    string[] cols = line.Split(',');

    dataGridView1.Rows.Add(cols[0], cols[1], cols[2], cols[3], cols[4]);
}
```
<img width="583" height="420" alt="image" src="https://github.com/user-attachments/assets/27e4c8e6-2b81-4112-9f7d-725aed7890a7" />

### Form9(MDI(Multiple Document Interface) 폼)
- MenuStrip 이용 (부모 폼에서 자식 폼을 오픈)
- MidWindowListItem - 해당 부분의 Name으로 설정시 창 생성시 리스트 보여줌
<img width="533" height="441" alt="image" src="https://github.com/user-attachments/assets/ce0499d7-7b37-49a3-86d5-af44ffa16a77" />

