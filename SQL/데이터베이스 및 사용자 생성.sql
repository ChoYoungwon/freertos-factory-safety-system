CREATE DATABASE madangdb;
CREATE USER madang@localhost IDENTIFIED BY 'madang';
GRANT ALL PRIVILEGES ON madangdb. * TO madang@localhost;
COMMIT;
SHOW DATABASES;