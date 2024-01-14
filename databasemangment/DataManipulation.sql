--UPDATE Sheet1$ SET origin='UNKNOWN' WHERE origin IS NULL; 
--DROP TABLE Country;

SELECT
    DISTINCT(origin) AS country
INTO Country
FROM
    Sheet1$;

ALTER TABLE Country
ADD countryID INT IDENTITY(1,1) PRIMARY KEY;
SELECT * FROM Country;

--DROP TABLE Brand;
SELECT 
    DISTINCT(p.Brand) AS brand,
	c.countryID
INTO Brand
FROM
    Sheet1$ p, Country c
WHERE p.origin = c.country;
ALTER TABLE Brand
ADD brandID INT IDENTITY(1,1) PRIMARY KEY;
SELECT * FROM Brand;


SELECT 
    p.productName,
	p.imagelink AS imgLink,
	p.productdesc AS description_,
	p.price, p.Quantity AS quantity,
	p.prodDate, p.expDate,
	b.brandID
INTO Product
FROM
    Sheet1$ p, Brand b, Country c
	WHERE p.Brand = b.brand
	AND b.countryID = c.countryID
	AND c.country = p.origin;
ALTER TABLE Product
ADD productID INT IDENTITY(1,1) PRIMARY KEY;
SELECT * FROM Product;

--Add foreign keys to product and brand:
--ALTER TABLE Product
--ADD FOREIGN KEY (brandID)
--REFERENCES Brand(brandID);


