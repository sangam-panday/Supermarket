CREATE DATABASE marketdb;
USE marketdb;

CREATE TABLE products(
ProductID INT NOT NULL,
ProductName VARCHAR(50),
Category VARCHAR(50),
Price DECIMAL(10, 2),
PRIMARY KEY(ProductID)
);


CREATE TABLE customer(
CustomerID INT NOT NULL,
CustomerName VARCHAR(50),
Phone VARCHAR(50),
Address VARCHAR(50),
PRIMARY KEY(CustomerID)
);