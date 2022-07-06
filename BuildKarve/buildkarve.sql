-- Karve Database by Ryan Young
-- Peer Reviewed by Bryce Murphy on 4/28/2021
-- Created on: 4/26/2021
-- Updated on: 4/28/2021
--
-- This script will create a new database, delete all existing tables if they already exist,
-- create 12 new tables, and bulk load the tables with data from CSV files.
-- To confirm that the process was done correctly, all 12 tables are selected and rows are counted.
--
--
-- CREATE DATABASE
IF NOT EXISTS(SELECT * FROM sys.databases
	WHERE NAME = N'Karve')
	CREATE DATABASE Karve
GO
USE Karve
--
-- CREATE PATH:
--
DECLARE @data_path NVARCHAR(256);
SELECT @data_path = 'C:\Users\Ryan Young\OneDrive - University of Denver\Documents\School\INFO 3240\Young_Database\';
--
-- DELETE EXISTING OBJECTS
--
IF EXISTS(
	SELECT *
	FROM sys.tables
	WHERE NAME = N'TuneLine'
       )
	DROP TABLE TuneLine;
--
IF EXISTS(
	SELECT *
	FROM sys.tables
	WHERE NAME = N'Tune'
       )
	DROP TABLE Tune;
--
IF EXISTS(
	SELECT *
	FROM sys.tables
	WHERE NAME = N'Rental'
       )
	DROP TABLE Rental;
--
IF EXISTS(
	SELECT *
	FROM sys.tables
	WHERE NAME = N'SkiBinding'
       )
	DROP TABLE SkiBinding;
--
IF EXISTS(
	SELECT *
	FROM sys.tables
	WHERE NAME = N'Binding'
       )
	DROP TABLE [Binding];
--
IF EXISTS(
	SELECT *
	FROM sys.tables
	WHERE NAME = N'Ski'
       )
	DROP TABLE Ski;
--
IF EXISTS(
	SELECT *
	FROM sys.tables
	WHERE NAME = N'SkiModel'
       )
	DROP TABLE SkiModel;
--
IF EXISTS(
	SELECT *
	FROM sys.tables
	WHERE NAME = N'BindingModel'
       )
	DROP TABLE BindingModel;
--
IF EXISTS(
	SELECT *
	FROM sys.tables
	WHERE NAME = N'Customer'
       )
	DROP TABLE Customer;
--
IF EXISTS(
	SELECT *
	FROM sys.tables
	WHERE NAME = N'State'
       )
	DROP TABLE [State];
--
IF EXISTS(
	SELECT *
	FROM sys.tables
	WHERE NAME = N'Brand'
       )
	DROP TABLE Brand;
--
IF EXISTS(
	SELECT *
	FROM sys.tables
	WHERE NAME = N'TuneType'
       )
	DROP TABLE TuneType;
--
--
-- CREATE TABLES
--
--
CREATE TABLE [State]
    (StateID            NVARCHAR(2) CONSTRAINT pk_state PRIMARY KEY,
    StateName           NVARCHAR(25) CONSTRAINT nn_state_name NOT NULL
    );
--
CREATE TABLE Brand
    (BrandName          NVARCHAR(30) CONSTRAINT pk_brand PRIMARY KEY,
    Country             NVARCHAR(50) CONSTRAINT nn_brand_country NOT NULL,
    [Description]       NVARCHAR(150) 
    );
--
CREATE TABLE TuneType
    (TuneTypeID         NVARCHAR(50) CONSTRAINT pk_tune_type PRIMARY KEY,
    ExpectedTime        INT CONSTRAINT nn_tune_type_exp_time NOT NULL
    );
--
CREATE TABLE Customer
    (CustomerID         INT CONSTRAINT pk_customer PRIMARY KEY,
    FirstName           NVARCHAR(30) CONSTRAINT nn_customer_first_name NOT NULL,
    LastName            NVARCHAR(30) CONSTRAINT nn_customer_last_name NOT NULL,
    Email               NVARCHAR(40) CONSTRAINT nn_customer_email NOT NULL,
    Street              NVARCHAR(50) CONSTRAINT nn_customer_street NOT NULL,
    City                NVARCHAR(50) CONSTRAINT nn_customer_city NOT NULL,
    [State]             NVARCHAR(2) CONSTRAINT fk_customer_state FOREIGN KEY REFERENCES [State](StateID),
    Zipcode             NVARCHAR(11) CONSTRAINT nn_customer_zipcode NOT NULL,
    SignupDate          DATE DEFAULT GETDATE(),
    DateOfBirth         DATE CONSTRAINT nn_customer_dob NOT NULL
		CONSTRAINT ck_customer_dob CHECK (DateOfBirth < GetDate()),
    NumRentalsPaid      INT CONSTRAINT nn_customer_num_rentals NOT NULL, -- This is the subscription level. How many skis can the customer rent at once?
    Height              INT CONSTRAINT nn_customer_height NOT NULL,
    [Weight]            INT CONSTRAINT nn_customer_weight NOT NULL,
    AbilityLevel        INT CONSTRAINT nn_customer_ability NOT NULL
        CONSTRAINT ck_customer_ability CHECK (AbilityLevel BETWEEN 1 AND 3),
    BootSize            NUMERIC(3,1)
		CONSTRAINT ck_customer_bootsize CHECK (BootSize BETWEEN 22.5 AND 32.5),
    BootSoleLength      INT CONSTRAINT nn_customer_bsl NOT NULL
		CONSTRAINT ck_customer_bsl CHECK (BootSoleLength BETWEEN 220 AND 390)
    );
--
CREATE TABLE BindingModel
    (BindingModelID     INT CONSTRAINT pk_binding_model PRIMARY KEY,
    Brand               NVARCHAR(30) CONSTRAINT fk_binding_model_brand FOREIGN KEY REFERENCES Brand(BrandName),
    [Name]              NVARCHAR(50) CONSTRAINT nn_binding_model_name NOT NULL,
    MaxDin              NUMERIC(5,1) CONSTRAINT nn_binding_model_max_din NOT NULL
		CONSTRAINT ck_binding_model_max_din CHECK (MaxDin BETWEEN 10 AND 18),
    MinDin              NUMERIC(5,1) CONSTRAINT nn_binding_model_min_din NOT NULL
		CONSTRAINT ck_binding_model_min_din CHECK (MinDin BETWEEN 2 AND 8),
    MaxBootSoleLength   INT CONSTRAINT nn_binding_model_max_bsl NOT NULL
		CONSTRAINT ck_binding_model_max_bsl CHECK (MaxBootSoleLength BETWEEN 220 AND 390),
    MinBootSoleLength   INT CONSTRAINT nn_binding_model_min_bsl NOT NULL
		CONSTRAINT ck_binding_model_min_bsl CHECK (MinBootSoleLength BETWEEN 220 AND 390),
    ModelYear           INT
    );
--
CREATE TABLE SkiModel
    (SkiModelID         INT CONSTRAINT pk_ski_model PRIMARY KEY,
    Brand               NVARCHAR(30) CONSTRAINT fk_ski_model_brand FOREIGN KEY REFERENCES Brand(BrandName),
    [Name]              NVARCHAR(50) CONSTRAINT nn_ski_model_name NOT NULL,
    WaistWidth          INT CONSTRAINT nn_ski_model_waist NOT NULL,
    ModelYear           INT,
    [Description]       NVARCHAR(200),
    [Image]             IMAGE
    );
--
CREATE TABLE [Binding]
    (BindingID          INT CONSTRAINT pk_binding PRIMARY KEY,
    BindingModelID      INT CONSTRAINT fk_binding_binding_model FOREIGN KEY REFERENCES BindingModel(BindingModelID),
    PurchaseDate        DATE CONSTRAINT ck_binding_purchase_date CHECK (PurchaseDate < GetDate()),
    Condition           NVARCHAR(100)
    );
--
CREATE TABLE Ski
    (SkiID              INT CONSTRAINT pk_ski PRIMARY KEY,
    SkiModelID          INT CONSTRAINT fk_ski_ski_model FOREIGN KEY REFERENCES SkiModel(SkiModelID),
    PurchaseDate        DATE CONSTRAINT ck_ski_purchase_date CHECK (PurchaseDate < GetDate()),
    [Length]            INT CONSTRAINT nn_ski_length NOT NULL
		CONSTRAINT ck_ski_length CHECK ([Length] BETWEEN 90 AND 210),
    Condition           NVARCHAR(100)
    );
--
CREATE TABLE SkiBinding
    (SkiBindingID       INT CONSTRAINT pk_ski_binding PRIMARY KEY,
    BindingID           INT CONSTRAINT fk_ski_binding_binding FOREIGN KEY REFERENCES [Binding](BindingID),
    SkiID               INT CONSTRAINT fk_ski_binding_ski FOREIGN KEY REFERENCES Ski(SkiID),
    MountDate           DATE CONSTRAINT nn_ski_binding_mount_date NOT NULL
		CONSTRAINT ck_ski_binding_mount_date CHECK (MountDate < GetDate())
    );
--
CREATE TABLE Rental
    (RentalID           INT CONSTRAINT pk_rental PRIMARY KEY,
    CustomerID          INT CONSTRAINT fk_rental_customer FOREIGN KEY REFERENCES Customer(CustomerID),
    SkiBindingID        INT CONSTRAINT fk_rental_ski_binding FOREIGN KEY REFERENCES SkiBinding(SkiBindingID),
    OrderDate           DATE DEFAULT GETDATE() CONSTRAINT nn_rental_order_date NOT NULL
		CONSTRAINT ck_rental_order_date CHECK (OrderDate < GetDate()),
    ReturnDate          DATE, -- Null when order is created
    DaysUsed            INT, -- Null when order is created
    Damage              BIT, -- Null when order is created
    DamageDescription   NVARCHAR(150) -- Null when order is created
    );
--
CREATE TABLE Tune
    (TuneID             INT CONSTRAINT pk_tune PRIMARY KEY,
    RentalID            INT CONSTRAINT fk_tune_rental FOREIGN KEY REFERENCES Rental(RentalID),
    [Date]              DATE DEFAULT GETDATE() CONSTRAINT nn_tune_date NOT NULL
		CONSTRAINT ck_tune_date CHECK ([Date] < GetDate())
    );
--
CREATE TABLE TuneLine
    (TuneID             INT CONSTRAINT nn_tune_line_id NOT NULL,
    TuneTypeID          NVARCHAR(50) CONSTRAINT nn_tune_line_type_id NOT NULL,
    CompletionTime      INT CONSTRAINT nn_tune_line_completion_time NOT NULL,
    CONSTRAINT pk_tune_line PRIMARY KEY (TuneID, TuneTypeID),
    CONSTRAINT fk_tune_line_tune FOREIGN KEY (TuneID) REFERENCES Tune(TuneID),
    CONSTRAINT fk_tune_line_tune_type FOREIGN KEY (TuneTypeID) REFERENCES TuneType(TuneTypeID)
    );
--
-- LOAD DATA
--
-- 
EXECUTE (N'BULK INSERT State FROM ''' + @data_path + N'STATE.csv''
WITH (
	CHECK_CONSTRAINTS,
	CODEPAGE=''ACP'',
	DATAFILETYPE = ''char'',
	FIELDTERMINATOR= '','',
	ROWTERMINATOR = ''\n'',
	KEEPIDENTITY,
	TABLOCK
	);
');
--
EXECUTE (N'BULK INSERT Brand FROM ''' + @data_path + N'BRAND.csv''
WITH (
	CHECK_CONSTRAINTS,
	CODEPAGE=''ACP'',
	DATAFILETYPE = ''char'',
	FIELDTERMINATOR= '','',
	ROWTERMINATOR = ''\n'',
	KEEPIDENTITY,
	TABLOCK
	);
');
--
EXECUTE (N'BULK INSERT TuneType FROM ''' + @data_path + N'TUNE_TYPE.csv''
WITH (
	CHECK_CONSTRAINTS,
	CODEPAGE=''ACP'',
	DATAFILETYPE = ''char'',
	FIELDTERMINATOR= '','',
	ROWTERMINATOR = ''\n'',
	KEEPIDENTITY,
	TABLOCK
	);
');
--
EXECUTE (N'BULK INSERT Customer FROM ''' + @data_path + N'CUSTOMER.csv''
WITH (
	CHECK_CONSTRAINTS,
	CODEPAGE=''ACP'',
	DATAFILETYPE = ''char'',
	FIELDTERMINATOR= '','',
	ROWTERMINATOR = ''\n'',
	KEEPIDENTITY,
	TABLOCK
	);
');
--
EXECUTE (N'BULK INSERT BindingModel FROM ''' + @data_path + N'BINDING_MODEL.csv''
WITH (
	CHECK_CONSTRAINTS,
	CODEPAGE=''ACP'',
	DATAFILETYPE = ''char'',
	FIELDTERMINATOR= '','',
	ROWTERMINATOR = ''\n'',
	KEEPIDENTITY,
	TABLOCK
	);
');
--
EXECUTE (N'BULK INSERT SkiModel FROM ''' + @data_path + N'SKI_MODEL.csv''
WITH (
	CHECK_CONSTRAINTS,
	CODEPAGE=''ACP'',
	DATAFILETYPE = ''char'',
	FIELDTERMINATOR= '','',
	ROWTERMINATOR = ''\n'',
	KEEPIDENTITY,
	TABLOCK
	);
');
--
EXECUTE (N'BULK INSERT Binding FROM ''' + @data_path + N'BINDING.csv''
WITH (
	CHECK_CONSTRAINTS,
	CODEPAGE=''ACP'',
	DATAFILETYPE = ''char'',
	FIELDTERMINATOR= '','',
	ROWTERMINATOR = ''\n'',
	KEEPIDENTITY,
	TABLOCK
	);
');
--
EXECUTE (N'BULK INSERT Ski FROM ''' + @data_path + N'SKI.csv''
WITH (
	CHECK_CONSTRAINTS,
	CODEPAGE=''ACP'',
	DATAFILETYPE = ''char'',
	FIELDTERMINATOR= '','',
	ROWTERMINATOR = ''\n'',
	KEEPIDENTITY,
	TABLOCK
	);
');
--
EXECUTE (N'BULK INSERT SkiBinding FROM ''' + @data_path + N'SKI_BINDING.csv''
WITH (
	CHECK_CONSTRAINTS,
	CODEPAGE=''ACP'',
	DATAFILETYPE = ''char'',
	FIELDTERMINATOR= '','',
	ROWTERMINATOR = ''\n'',
	KEEPIDENTITY,
	TABLOCK
	);
');
--
EXECUTE (N'BULK INSERT Rental FROM ''' + @data_path + N'RENTAL.csv''
WITH (
	CHECK_CONSTRAINTS,
	CODEPAGE=''ACP'',
	DATAFILETYPE = ''char'',
	FIELDTERMINATOR= '','',
	ROWTERMINATOR = ''\n'',
	KEEPIDENTITY,
	TABLOCK
	);
');
--
EXECUTE (N'BULK INSERT Tune FROM ''' + @data_path + N'TUNE.csv''
WITH (
	CHECK_CONSTRAINTS,
	CODEPAGE=''ACP'',
	DATAFILETYPE = ''char'',
	FIELDTERMINATOR= '','',
	ROWTERMINATOR = ''\n'',
	KEEPIDENTITY,
	TABLOCK
	);
');
--
EXECUTE (N'BULK INSERT TuneLine FROM ''' + @data_path + N'TUNE_LINE.csv''
WITH (
	CHECK_CONSTRAINTS,
	CODEPAGE=''ACP'',
	DATAFILETYPE = ''char'',
	FIELDTERMINATOR= '','',
	ROWTERMINATOR = ''\n'',
	KEEPIDENTITY,
	TABLOCK
	);
');
--
-- List table names and row counts for confirmation
--
GO
SET NOCOUNT ON
SELECT 'Binding' AS "Table",	COUNT(*) AS "Rows"	FROM [Binding]	    UNION
SELECT 'BindingModel',		    COUNT(*)			FROM BindingModel   UNION
SELECT 'Customer',				COUNT(*)			FROM Customer       UNION
SELECT 'Rental',				COUNT(*)			FROM Rental         UNION
SELECT 'Ski',					COUNT(*)			FROM Ski            UNION
SELECT 'SkiBinding',			COUNT(*)			FROM SkiBinding     UNION
SELECT 'SkiModel',				COUNT(*)			FROM SkiModel       UNION
SELECT 'State',				    COUNT(*)			FROM [State]        UNION
SELECT 'Brand',				    COUNT(*)			FROM Brand          UNION
SELECT 'TuneType',				COUNT(*)			FROM TuneType       UNION
SELECT 'TuneLine',				COUNT(*)			FROM TuneLine       UNION
SELECT 'Tune',					COUNT(*)			FROM Tune       
ORDER BY 1;
SET NOCOUNT OFF
GO














