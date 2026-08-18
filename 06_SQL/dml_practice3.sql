-- 뷰의 생성 --
# 주소에 '대한민국'을 포함하는 고객들로 구성된 뷰를 만들고 조회(이름 : vw_Customer)
CREATE VIEW vw_Customer
AS SELECT *
	FROM customer
	WHERE address LIKE '%대한민국%';

SELECT * FROM vw_Customer;

# orders 테이블에서 고객이름과 도서이름을 바로 확인할 수 있는 뷰를 생성한 후, 
# '김연아' 고객이 구입한 도서의 주문번호, 도서이름, 주문액을 나타내시오
CREATE VIEW vw_orders (orderid, custid, NAME, bookid, bookname, saleprice, orderdate)
AS SELECT od.orderid, od.custid, cs.name, od.bookid, bk.bookname, od.saleprice, od.orderdate
FROM orders od, customer cs, book bk
WHERE od.custid=cs.custid AND od.bookid=bk.bookid;

SELECT orderid, bookname, saleprice
FROM vw_orders
WHERE NAME ='김연아';

-- 뷰의 수정--
# vw_Customer 는 주소가 대한민국인 고객만 보여준다 이 뷰를 영국을 주소로 가진 고객으로 변경
# phone 속성은 포함하지말 것
CREATE OR REPLACE VIEW vw_customer (custid, NAME, address)
AS SELECT custid, NAME, address
FROM customer
WHERE address LIKE '%영국%';

SELECT * FROM vw_customer;

-- 뷰의 삭제 --
# vw_Customer를 삭제
DROP VIEW vw_customer;

-- 인덱스 --
# Book 테이블의 bookname 열을 대상으로 ix_Book을 생성
CREATE INDEX ix_Book ON book(bookname);

# Book 테이블의 publisher, price 열을 대상으로 인덱스 ix_Book2를 생성
CREATE INDEX ix_Book2 ON book(publisher, price);

# 인덱스 확인
SHOW INDEX FROM book;

SELECT *
FROM book
WHERE publisher='대한미디어' AND price >= 30000;

# Book 테이블의 인덱스를 최적화
# B-tree 인덱스는 데이터의 수정, 삭제, 삽입이 잦으면 노드의 갱신이 주기적으로 일어나
# 단편화 현상이 나타남 -> analyze 문법으로 인덱스를 다시 생성
ANALYZE TABLE book;

# 인덱스 삭제
DROP INDEX ix_book ON book;

-- 프로시저
# 어떤 프로세스를 절차적으로 기술해 놓은 것 (자주 실행하는 SQL 쿼리 문장들을 저장해주는 기능)

# Book 테이블에 한 개의 투플을 삽입하는 프로시저
USE madangdb;
delimiter //
CREATE PROCEDURE InsertBook(
	IN mybookid 	INTEGER,
	IN mybookname 	VARCHAR(40),
	IN mypublisher VARCHAR(40),
	IN myprice 		INTEGER)
BEGIN
	INSERT INTO book(bookid, bookname, publisher, price)
		VALUES(mybookid, mybookname, mypublisher, myprice);
END;
//
delimiter ;

CALL insertbook(13, '스포츠과학', '마당과학서적', 25000);
SELECT * FROM book;

# 동일한 도서가 있는지 점검한 후 삽입하는 프로시저
USE madangdb;
delimiter //
CREATE PROCEDURE BookInsertOrUpdate(
	mybookid 	INTEGER,
	mybookname	VARCHAR(40),
	mypublisher	VARCHAR(40),
	myprice		INT)
BEGIN
	DECLARE mycount INTEGER;
	SELECT COUNT(*) INTO mycount FROM book
		WHERE bookname LIKE mybookname;
	if mycount!=0 then
		SET SQL_SAFE_UPDATES=0;	/*DELETE, UPDATE 연산에 필요한 설정문*/
		UPDATE book SET price = myprice
			WHERE bookname LIKE mybookname;
	ELSE 
		INSERT INTO book(bookid, bookname, publisher, price)
			VALUES(mybookid, mybookname, mypublisher, myprice);
	END if;
END;
//
delimiter ;

# 프로시저 실행하여 테스트
CALL BookInsertOrUpdate(15, '스포츠 즐거움', '마당과학서적', 25000);
SELECT * FROM book;
CALL BookInsertOrUpdate(15, '스포츠 즐거움', '마당과학서적', 20000);
SELECT * FROM book;

# Book 테이블에 저장된 도서의 평균 가격을 반환하는 프로시저
delimiter //
CREATE PROCEDURE Averageprice(
	OUT AverageVal INTEGER)
BEGIN
	SELECT AVG(price) INTO AverageVal
	FROM book WHERE price IS NOT NULL;
END;
//
delimiter ;

# 테스트
CALL Averageprice(@myValue);
SELECT @myValue;

# 프로시저 확인
SHOW PROCEDURE STATUS WHERE db='madangdb';
# 프로시저 삭제(후 재등록 가능)
DROP PROCEDURE Averageprice;

-- 트리거
# SET GLOBAL log_bin_trust_function_creators=ON; (root에서 실행)
CREATE TABLE book_log(
	bookid_l INTEGER,
	bookname_l VARCHAR(40),
	publisher_l VARCHAR(40),
	price_l integer
);

# 신규 도서 삽입 후 자동으로 Book_log 테이블에 삽입 내용을 기록하는 트리거
delimiter //
CREATE TRIGGER AfterInsertBook
	AFTER INSERT ON book FOR EACH row
BEGIN
	DECLARE average INTEGER;
	INSERT INTO book_log
	VALUES(NEW.bookid, NEW.bookname, NEW.publisher, NEW.price);
END;
//
delimiter ;
SELECT * FROM book;
INSERT INTO book VALUES(16, '스포츠 과학 1', '이상미디어', 25000);
SELECT * FROM book WHERE bookid = 16; 
SELECT * FROM book_log WHERE bookid_l = 16;