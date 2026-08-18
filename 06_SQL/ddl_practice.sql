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
# ALTER TABLE newbook ADD PRIMARY KEY(bookid);

# NewBook 테이블 삭제
DROP TABLE newcustomer;
DROP TABLE neworders;
DROP TABLE newbook;

SELECT * FROM book;
SELECT * FROM imported_book;

# book 테이블에 투플 삽입
INSERT INTO book(bookid, bookname, publisher, price) VALUES (11, '스포츠 의학', '한솔의학서적', 90000);

# book 테이블에 투플 삽입(가격 미정)
INSERT INTO book(bookid, bookname, publisher) VALUES (14, '스포츠 의학', '한솔의학서적');

# 수입 도서 목록을 Book 테이블에 삽입
INSERT INTO book(bookid, bookname, price, publisher) SELECT bookid, bookname, price, publisher FROM imported_book;

select * FROM customer;

# Customer 테이블에서 고객번호가 5인 고객의 주소를 '대한민국 부산'으로 변경
UPDATE customer SET address = '대한민국 부산' WHERE custid = 5;

# book 테이블에서 14번 스포츠 의학의 출판사를 imported_book 테이블에 있는 21번 책의 출판사와 동일하게 변경
UPDATE book SET publisher = (SELECT publisher FROM imported_book WHERE bookid = 21) WHERE bookid = 14;

# book 테이블에서 도서 번호가 11인 도서를 삭제
DELETE FROM book WHERE bookid = 11;

# 모든 고객을 삭제
DELETE FROM customer;