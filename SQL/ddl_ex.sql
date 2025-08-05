# 테이블 생성(NewBook)
CREATE TABLE NewBook (
	bookid INTEGER,
	bookname VARCHAR(20)	NOT null,
	publisher VARCHAR(20)	unique,
	price INTEGER	DEFAULT 1000 CHECK(price >= 1000),
	PRIMARY KEY (bookid)
);

# 테이블 생성 (NewCustomer)
CREATE TABLE NewCustomer (
	custid INTEGER PRIMARY KEY,
	NAME VARCHAR(40),
	address VARCHAR(40),
	phone VARCHAR(30)
);

# 테이블 생성 (NewOrders)
CREATE TABLE NewOrders (
	orderid INTEGER,
	custid INTEGER NOT null,
	bookid INTEGER NOT NULL,
	saleprice INTEGER,
	orderdate DATE,
	PRIMARY KEY(orderid),
	FOREIGN KEY(custid) REFERENCES NewCustomer(custid) ON DELETE CASCADE, 
	FOREIGN KEY(bookid) REFERENCES NewBook(bookid) ON DELETE CASCADE
);

DESCRIBE newbook;

# NewBook 테이블에 VARCHAR(13)의 자료형을 가진 isbn 속성을 추가
ALTER TABLE NewBook ADD isbn VARCHAR(13);

# NewBook 테이블에서 isbn 속성의 데이터 타입을 INTEGER형으로 변경
ALTER TABLE newbook MODIFY isbn INTEGER;

# NewBook 테이블의 isbn 속성을 삭제
ALTER TABLE newbook DROP COLUMN isbn;

# NewBook 테이블의 bookname 속성에 NOT NULL 제약조건을 적용, 제거
ALTER TABLE newbook MODIFY bookname VARCHAR(20) NULL;
ALTER TABLE newbook MODIFY bookname VARCHAR(20) NOT NULL;

# NewBook 테이블의 bookid 속성을 기본키로 변경
ALTER TABLE newbook ADD PRIMARY KEY(bookid);


