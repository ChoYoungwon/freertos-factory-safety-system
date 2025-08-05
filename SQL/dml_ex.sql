SHOW TABLES;
SELECT * FROM book;
SELECT * FROM customer;
select * FROM orders;
DESCRIBE book;
DESCRIBE orders;
DESCRIBE customer;

SELECT bookname, price FROM book;

SELECT * FROM book WHERE price BETWEEN 10000 AND 20000;

SELECT * FROM customer, orders WHERE customer.custid = orders.custid;