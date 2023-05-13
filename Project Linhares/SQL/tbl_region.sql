DROP TABLE tbl_region;

CREATE TABLE tbl_region (
	Id INT IDENTITY(1, 1) NOT NULL
	,IdCountry INT NOT NULL
	,NAME VARCHAR(120) NOT NULL
	);

CREATE CLUSTERED INDEX Id ON tbl_document (Id); 