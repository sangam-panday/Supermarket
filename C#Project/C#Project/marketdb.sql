CREATE DATABASE marketdb;
USE marketdb;
CREATE TABLE products(
ProductID INT NOT NULL,
ProductName VARCHAR(50),
Category VARCHAR(50),
Price DECIMAL(10, 2),
PRIMARY KEY(ProductID)
);