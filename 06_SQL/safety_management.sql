CREATE DATABASE if NOT EXISTS safetyDB;

CREATE TABLE if NOT EXISTS systemdata (
	id INTEGER AUTO_INCREMENT PRIMARY KEY,
	nowtime DATE,
	temperature DOUBLE,
	humidity DOUBLE,
	flame BOOL,
	functioning BOOL  
);

SELECT * FROM systemdata;
DESCRIBE systemdata;
