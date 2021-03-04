CREATE TABLE Brands(
	BrandId int PRIMARY KEY IDENTITY(1,1),
	BrandName nvarchar(25),
)

INSERT INTO Brands(BrandName)
VALUES
	('Tesla'),
	('BMW'),
	('Renault');