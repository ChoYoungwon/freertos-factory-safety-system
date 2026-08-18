# 데이터 스키마 생성
CREATE DATABASE madangdb;

# 사용자 생성(호스트명 : madang, 비밀번호 : madang)
CREATE USER madang@localhost IDENTIFIED BY 'madang';

# madang사용자에게 madangdb의 모든 권한 부여
GRANT ALL PRIVILEGES ON madangdb. * TO madang@localhost;

# 변경사항 저장
COMMIT;
SHOW DATABASES;