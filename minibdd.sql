DROP DATABASE IF EXISTS enterprise

GO

CREATE DATABASE enterprise;

GO

USE enterprise;

CREATE TABLE customers (
  id_customer INT IDENTITY NOT NULL,
  nif CHAR(9) NOT NULL CHECK (LEN(nif)=9),
  name VARCHAR(40) NOT NULL,  
  surname VARCHAR(80) NOT NULL, 
  birth_date DATETIME NOT NULL CHECK (birth_date BETWEEN 1-1-1900 AND GETDATE()),
  gender CHAR(1) NOT NULL CHECK (gender = 'm' OR gender = 'w'),
  email VARCHAR(255) NOT NULL CHECK (email like '%@%.%'),
  phone_number CHAR(9) CHECK (LEN(phone)=9),
  credit_card CHAR(16) CHECK (LEN(credit_card)=16),
  PRIMARY KEY (id_customer)
);

CREATE TABLE manufacturers (
  id_manufacturer INT NOT NULL IDENTITY,
  name VARCHAR (80) NOT NULL,
  municipality VARCHAR(80) NOT NULL,
  PRIMARY KEY (id_manufacturer) 
);

CREATE TABLE products (
  id_product INT IDENTITY NOT NULL,
  title VARCHAR(80) NOT NULL, 
  manufacturer INT, 
  price MONEY NOT NULL 
  PRIMARY KEY (id_product),
  FOREIGN KEY (manufacturer) REFERENCES manufacturers(id_manufacturer)
);

CREATE TABLE buys(
  id_buys INT IDENTITY NOT NULL,
  manufacturer INT NOT NULL,
  customer INT NOT NULL,
  buy_date DATETIME,
  units INT NOT NULL,
  PRIMARY KEY (id_buys),
  FOREIGN KEY (manufacturer) REFERENCES  manufacturers(id_manufacturer),
  FOREIGN KEY (customer) REFERENCES customers(id_customer)
);

