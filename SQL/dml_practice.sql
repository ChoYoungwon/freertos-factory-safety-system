SELECT * FROM book;
SELECT * FROM customer;
SELECT * FROM imported_boook;
SELECT * FROM orders;

DESCRIBE book;
DESCRIBE customer;
DESCRIBE imported_book;
DESCRIBE orders;

# 고객이 주문한 도서의 총판매액
SELECT SUM(saleprice) FROM orders;

# 2번 고객이 주문한 도서의 총판매액
SELECT sum(saleprice) AS 총매출 FROM orders WHERE custid=2;

# 고객별로 주문한 도서의 총수량과 총판매액
SELECT custid, COUNT(*) AS 도서수량, SUM(saleprice) AS 총액 
FROM orders 
GROUP BY custid;

# 가격이 8000원 이상인 도서를 구매한 고객에 대하여 고객별 주문 도서의 총 수량을 구한다.
# 단, 2권 이상 구매한 고객에 대해서만 구함
SELECT custid, COUNT(*) AS 도서수량
FROM orders
WHERE saleprice >= 8000
GROUP BY custid
HAVING COUNT(*) >= 2;

# 고객과 고객의 주문에 관한 데이터를 나타냄
SELECT *
FROM customer, orders
WHERE customer.custid = orders.custid;

# 고객과 고객의 주문에 관한 데이터를 고객별로 정렬
SELECT *
FROM customer, orders
WHERE customer.custid = orders.custid
ORDER BY customer.custid;

# 고객의 이름과 고객이 주문한 도서의 판매가격을 검색
SELECT NAME, saleprice
FROM customer, orders
WHERE customer.custid = orders.custid;

# 고객별로 주문한 모든 도서의 총판매액을 구하고, 고객별로 정렬
SELECT NAME, sum(saleprice)
FROM customer, orders
WHERE customer.custid = orders.custid
GROUP BY customer.custid
ORDER BY customer.name;

# 고객의 이름과 고객이 주문한 도서의 이름을 구함
SELECT customer.name, book.bookname
FROM customer, orders, book
WHERE customer.custid = orders.custid AND orders.bookid = book.bookid;

# 가격이 20,000원인 도서를 주문한 고객의 이름과 도서의 이름
SELECT customer.name, book.bookname
FROM customer, orders, book
WHERE customer.custid = orders.custid AND orders.bookid = book.bookid AND book.price=20000;

# 도서를 구매하지 않은 고객을 포함해 고객의 이름과 고객이 주문한 도서의 판매가격을 구함
SELECT customer.name, orders.saleprice
FROM customer LEFT OUTER JOIN orders ON customer.custid = orders.custid;

# 도서를 구매한 적이 있는 고객의 이름을 검색
SELECT NAME
FROM customer
WHERE custid IN (SELECT custid FROM orders);

# 대한미디어에서 출판한 도서를 구매한 고객의 이름
SELECT NAME
FROM customer, orders, book
WHERE customer.custid = orders.custid 
	AND orders.bookid = book.bookid 
	AND book.publisher = '대한미디어';

# 출판사별로 출판사의 평균 도서 가격보다 비싼 도서
SELECT b1.bookname
FROM book b1
WHERE b1.price > (SELECT AVG(b2.price)
						FROM book b2 
						WHERE b2.publisher=b1.publisher);
						
# 대한민국에 거주하는 고객의 이름과 도서를 주문한 고객의 이름을 나타내시오
SELECT NAME 
FROM customer 
WHERE address LIKE '대한민국%'
UNION
SELECT NAME 
FROM customer 
WHERE custid in (SELECT custid FROM orders);

# 가장 비싼 도서의 이름
select bookname
FROM book
WHERE price = (select MAX(price) FROM book);

# 도서를 구매한 적이 있는 고객의 이름을 검색
SELECT NAME
FROM customer
WHERE custid IN (SELECT custid FROM orders);

# 대한미디어에서 출판한 도서를 구매한 고객의 이름
SELECT NAME
FROM customer
WHERE custid IN (SELECT custid 
						FROM orders, book
						WHERE orders.bookid = book.bookid 
							AND book.publisher='대한미디어');
							
# 주문이 있는 고객의 이름과 주소
SELECT NAME, address
FROM customer 
WHERE EXISTS (SELECT * 
					FROM orders 
					WHERE customer.custid=orders.custid);

					

									