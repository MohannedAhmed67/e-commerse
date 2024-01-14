CREATE TABLE Customer (
	custID		INT				IDENTITY(1,1) PRIMARY KEY,
	userName	VARCHAR(64)		UNIQUE	NOT NULL,
	email		VARCHAR(256)	UNIQUE,
	custName	VARCHAR(64)		NOT NULL,
	phoneNum	VARCHAR(22),
	gender		VARCHAR(1),
	address		VARCHAR(256),
	password	CHAR(32)		NOT NULL
);

CREATE TABLE Order_(
	orderID		INT		IDENTITY(1,1) PRIMARY	KEY,
	custID		INT		FOREIGN KEY REFERENCES Customer(custID),
	transState	CHAR(20),
	orderDate	DATETIME
);

CREATE TABLE Country (
	countryID		INT				IDENTITY(1,1) PRIMARY KEY,
	countryName		VARCHAR(128)	NOT NULL
);


CREATE TABLE Brand (
	brandID		INT				IDENTITY(1,1) PRIMARY KEY,
	brandName	VARCHAR(256)	NOT NULL,
	originID	INT				FOREIGN KEY REFERENCES Country(countryID)
);

CREATE TABLE Product (
	productID		INT				IDENTITY(1,1) PRIMARY KEY,
	productName		VARCHAR(256)	NOT NULL,
	quantity		VARCHAR(64)		NOT NULL,
	price			FLOAT			NOT NULL,
	description_	TEXT,
	img				VARCHAR(256),
	prodDate		DATE,
	expDate			DATE,
	brandID			INT				FOREIGN KEY REFERENCES Brand(brandID),
);

CREATE TABLE Order_Product (
	productID		INT			FOREIGN KEY REFERENCES Order_(orderID),
	orderID			INT			FOREIGN KEY REFERENCES Product(productID),
	quantity		VARCHAR(64) DEFAULT(1),
	CONSTRAINT PK_Order_Product PRIMARY KEY (productID, orderID)
);

CREATE VIEW CountLastDay AS
SELECT productID, COUNT(*) as sold_last_day 
FROM Order_Product 
WHERE orderID IN(
SELECT orderID 
FROM Order_ 
WHERE DATEDIFF(HOUR,orderDate,GETDATE())<24) 
GROUP BY productID;

--Signin and signup
INSERT INTO Customer(userName, custName, phoneNum, gender, address, email, password)
VALUES ('Ahmed@ejust','Ahmed','123','M','Egypt','ahmed@gmail.com','pass');

SELECT custID FROM Customer WHERE userName = 'Ahmed@ejust' AND password = 'pass';
SELECT custID FROM Customer WHERE email = '' AND password = '';

--show tables
SELECT 
    p.productName, 
    p.quantity, 
    p.price, 
    p.description_, 
    p.img, 
    p.prodDate, 
    p.expDate, 
    br.brandName, 
	c.countryName AS BrandOriigon,
    s.suppName, 
	cc.countryName AS SuppOringin,
    op.total_sold,
	opp.sold_last_day
FROM 
    Product p
JOIN 
    Brand br ON p.brandID = br.brandID
JOIN 
    Supplier s ON p.suppID = s.suppID
JOIN
	Country c ON (br.originID = c.countryID AND s.nationalityID = c.countryID)
JOIN
	Country cc ON s.nationalityID = c.countryID
JOIN 
    (SELECT productID, COUNT(*) as total_sold FROM Order_Product GROUP BY productID) op ON p.productID = op.productID
JOIN 
    CountLastDay opp ON p.productID = opp.productID;

--WHERE p.price  BETWEEN 10 AND 20;
--WHERE br.brandName LIKE '';
--WHERE c.countryName 'Egypt';

--SELECT COUNT(*) FROM Order_Product WHERE ProductID = ......;
--Add new order
INSERT INTO Order_(custID, transState, orderDate)
VALUES(2,'paid',GETDATE());
--SELECT * FROM Order_; 

--Add to cart
INSERT INTO Order_Product(orderID, productID, quantity)
VALUES(1,1,1);
--Delete from cart
DELETE FROM Order_Product WHERE orderID = 1 AND productID = 1;

--Show cart contents
SELECT op.productID, op.quantity, p.productName, p.price, p.description_, p.img, b.brandName, s.suppName, p.prodDate, p.expDate, o.transState
FROM Order_Product op 
JOIN 
	Product p ON op.productID = p.productID
JOIN 
	Order_ o ON op.orderID = o.orderID
JOIN 
	Brand b ON p.brandID = b.brandID
JOIN 
	Supplier s ON p.suppID = s.suppID
WHERE op.OrderID = (SELECT OrderID FROM Order_ WHERE CustID=1);

