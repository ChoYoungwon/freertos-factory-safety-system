SELECT * FROM book;
SELECT * FROM customer;
SELECT * FROM orders;
SELECT * FROM imported_book;

# 도서 제목에 야구가 포함된 도서를 농구로 변경한 후 도서 목록을 나타내기
SELECT bookid, REPLACE(bookname, '야구', '농구') bookname, publisher, price
FROM book;

# 굿스포츠에서 출판한 도서의 제목과 제목의 문자 수, 바이트 수를 나타내기
SELECT bookname '제목', CHAR_LENGTH(bookname) '문자수', LENGTH(bookname) '바이트 수'
FROM book
WHERE publisher = '굿스포츠';

# 마당서점의 고객 중에서 성이 같은 사람이 몇 명이 되는지 알기 위해 성별 인원수를 구한다.
SELECT SUBSTR(NAME, 1, 1) '성', COUNT(*) 인원
FROM customer
GROUP BY SUBSTR(NAME, 1, 1);

# 날짜 시간 함수(date형의 날짜에서 INTERVAL 지정한 시간만큼 더함)
SELECT ADDDATE('2024-07-01', INTERVAL -5 DAY) befores,
		 ADDDATE('2024-07-01', INTERVAL 5 DAY) afters;
		 
# 마당서점은 지문일로부터 10일 후에 매출을 확정한다. 각 주문의 확정일자를 구하기
SELECT orderid '주문번호', orderdate '주문일', ADDDATE(orderdate, INTERVAL 10 DAY) '확정'
FROM orders;

# 현재 시간 포맷 지정
SELECT SYSDATE(), DATE_FORMAT(SYSDATE(), '%Y%m%d:%H%i%s');
		 
# 마당서점이 2024년 7월 7일에 주문받은 도서의 주문번호, 주문일, 고객번호, 도서번호를 모두 나타내시오
# 단, 주문일은 '%Y-%m-%d'형태로 표시함
SELECT orderid '주문번호', date_format(orderdate, '%Y-%m-%d') '주문일',
		 custid '고객번호', bookid '도서번호'
FROM orders
WHERE orderdate = STR_TO_DATE('20240707','%Y%m%d');

# DBMS 서버에 설정된 현재 날짜와 시간, 요일을 확인하기
SELECT SYSDATE(), DATE_FORMAT(SYSDATE(), '%Y/%m/%d %a %h:%i') 'sysdate_1';
 
# 이름, 전화번호가 포함된 고객 목록을 나타낼 것, 단 전화번호가 없는 고객은 '연락처없음'으로 표시
SELECT NAME '이름', IFNULL(phone, '연락처없음') '전화번호'
FROM customer;

# SET : 변수는 이름 앞에 @ 기호를 붙이며 치환문에는 SET과 := 기호를 사용한다.
SET @seq:=0;

# 고객 목록에서 고객번호, 이름, 전화번호를 앞의 2명만 나타낼 것
SELECT (@seq:=@seq+1) '순번', custid, NAME, phone
FROM customer
WHERE @seq < 2;
		 
# 평균 주문금액 이하의 주문에 대해서 주문번호와 금액을 나타낼것
SELECT orderid, saleprice
FROM orders
WHERE saleprice <= (SELECT AVG(saleprice) 
							FROM orders);	 
		 
# SET sql_safe_updates = 0;		 
		 
# 각 고객의 평균 주문금액보다 큰 금액의 주문 내역에 대해서 주문번호, 
# 고객번호, 금액을 나타내시오
SELECT orderid, custid, saleprice
FROM orders od1
WHERE saleprice > (SELECT AVG(saleprice)
						FROM orders od2
						WHERE od1.custid=od2.custid);

# 대한민국에 거주하는 고객에게 판매한 도서의 총 판매액을 구하기
SELECT SUM(saleprice) 'total'
FROM orders
WHERE custid IN (SELECT custid 
						FROM customer
						WHERE address LIKE '%대한민국%');

# 3번 고객이 주문한 도서의 최고 금액보다 더 비싼 도서를 구입한 주문의 주문번호와 판매금액을 보이라
SELECT orderid, saleprice
FROM orders
WHERE saleprice > all (SELECT saleprice
								FROM orders 
								WHERE custid='3');

# EXISTS 연산자를 사용하여 대한민국에 거주하는 고객에게 판매한 도서의 총 판매액을 구하기
SELECT SUM(saleprice) 'total'
FROM orders
WHERE EXISTS (SELECT * 
					FROM customer
					WHERE address LIKE '%대한민국%' AND customer.custid=orders.custid);
					
# 스칼라 부속질의
# 마당서점의 고객별 판매액을 나타내시오(고객이름과 고객별 판매액 출력)
SELECT (SELECT NAME
			FROM customer cs
			WHERE cs.custid=od.custid) 'name', SUM(saleprice) 'total'
FROM orders od
GROUP BY od.custid;

# orders 테이블에 각 주문에 맞는 도서이름을 입력하기
ALTER TABLE orders ADD bname VARCHAR(40);
UPDATE orders
SET bname = (SELECT bookname
					FROM book
					WHERE book.bookid = orders.bookid);

# 고객번호가 2 이하인 고객의 판매액을 나타낼 것
SELECT cs.name, SUM(od.saleprice) 'total'
FROM (SELECT custid, NAME
		FROM customer
		WHERE custid <= 2) cs,
		orders od
WHERE cs.custid = od.custid
GROUP BY cs.name;









