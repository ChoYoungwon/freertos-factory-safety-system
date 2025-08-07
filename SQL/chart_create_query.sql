SELECT * FROM book;
SELECT * FROM orders;
SELECT * FROM customer;
SELECT * FROM user;
DESCRIBE users;

create table chartData (
	seq    integer  PRIMARY KEY,
	value1 INTEGER,
    value2 float,
    sendTime datetime
);

ALTER TABLE chartdata
MODIFY COLUMN seq INT NOT NULL AUTO_INCREMENT;

SELECT * FROM chartData;
DELETE FROM chartData WHERE seq > 0;