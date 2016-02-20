
mysql -uusername -ppassword

DROP DATABASE IF EXISTS mvc5;
CREATE DATABASE mvc5;
USE mvc5;

use mvc5;
DROP TABLE IF EXISTS people;
CREATE TABLE people (
  id int(11) NOT NULL AUTO_INCREMENT,
  first_name varchar(20) DEFAULT NULL,
  last_name varchar(20) DEFAULT NULL,
  birth_date date DEFAULT NULL,
  PRIMARY KEY (id)
);

insert into people (first_name) values ('SomeGuy');
insert into people (first_name,last_name,birth_date) values ('Some', 'Guy','0001-01-01');
insert into people (first_name,last_name,birth_date) values ('Some', 'Guy','0001-01-01');

use mvc5;
select * from people;
