[<img src="https://github.com/ryayoung/icons/blob/main/svg/arrow.left.blue.svg" height="30"/>](README.md)

# SQL Server Database: Karve Ski Demos

---

> Karve is an online ski demo subscription for enthusiasts who always want the ideal gear for current snow conditions. Members have access to hundreds of skis at the touch of a button, delivered to their doorstep, with the freedom to swap products at any time with no additional cost.

## Database Design: *Version 1*
> In the later stages of this project, the database design changes significantly. This is the design used for the .NET forms app.

![image](https://user-images.githubusercontent.com/90723578/136710522-a44f98dc-d7bf-4756-89f2-b80a134231af.png)


### <a href="https://github.com/ryayoung/karve-forms-app/blob/main/BuildKarve/buildkarve.sql"><img src="https://github.com/ryayoung/icons/blob/main/svg/code.slash.blue.svg" height="18"/> &nbsp; Full Build Script</a>

### Tables:

#### ```State```
```sql
CREATE TABLE [State]
    (StateID            NVARCHAR(2) CONSTRAINT pk_state PRIMARY KEY,
    StateName           NVARCHAR(25) CONSTRAINT nn_state_name NOT NULL
    );
```

#### ```Brand```
```sql
CREATE TABLE Brand
    (BrandName          NVARCHAR(30) CONSTRAINT pk_brand PRIMARY KEY,
    Country             NVARCHAR(50) CONSTRAINT nn_brand_country NOT NULL,
    [Description]       NVARCHAR(150) 
    );
```

#### ```TuneType```
```sql
CREATE TABLE TuneType
    (TuneTypeID         NVARCHAR(50) CONSTRAINT pk_tune_type PRIMARY KEY,
    ExpectedTime        INT CONSTRAINT nn_tune_type_exp_time NOT NULL
    );
```

#### ```Customer```
```sql
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
```

#### ```BindingModel```
```sql
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
```

#### ```SkiModel```
```sql
CREATE TABLE SkiModel
    (SkiModelID         INT CONSTRAINT pk_ski_model PRIMARY KEY,
    Brand               NVARCHAR(30) CONSTRAINT fk_ski_model_brand FOREIGN KEY REFERENCES Brand(BrandName),
    [Name]              NVARCHAR(50) CONSTRAINT nn_ski_model_name NOT NULL,
    WaistWidth          INT CONSTRAINT nn_ski_model_waist NOT NULL,
    ModelYear           INT,
    [Description]       NVARCHAR(200),
    [Image]             IMAGE
    );
```

#### ```Binding```
```sql
CREATE TABLE [Binding]
    (BindingID          INT CONSTRAINT pk_binding PRIMARY KEY,
    BindingModelID      INT CONSTRAINT fk_binding_binding_model FOREIGN KEY REFERENCES BindingModel(BindingModelID),
    PurchaseDate        DATE CONSTRAINT ck_binding_purchase_date CHECK (PurchaseDate < GetDate()),
    Condition           NVARCHAR(100)
    );
```

#### ```Ski```
```sql
CREATE TABLE Ski
    (SkiID              INT CONSTRAINT pk_ski PRIMARY KEY,
    SkiModelID          INT CONSTRAINT fk_ski_ski_model FOREIGN KEY REFERENCES SkiModel(SkiModelID),
    PurchaseDate        DATE CONSTRAINT ck_ski_purchase_date CHECK (PurchaseDate < GetDate()),
    [Length]            INT CONSTRAINT nn_ski_length NOT NULL
		CONSTRAINT ck_ski_length CHECK ([Length] BETWEEN 90 AND 210),
    Condition           NVARCHAR(100)
    );
```

#### ```SkiBinding```
> This is the actual inventory unit exchanged with customers. It is a binding mounted on a pair of skis.
```sql
CREATE TABLE SkiBinding
    (SkiBindingID       INT CONSTRAINT pk_ski_binding PRIMARY KEY,
    BindingID           INT CONSTRAINT fk_ski_binding_binding FOREIGN KEY REFERENCES [Binding](BindingID),
    SkiID               INT CONSTRAINT fk_ski_binding_ski FOREIGN KEY REFERENCES Ski(SkiID),
    MountDate           DATE CONSTRAINT nn_ski_binding_mount_date NOT NULL
		CONSTRAINT ck_ski_binding_mount_date CHECK (MountDate < GetDate())
    );
```

#### ```Rental```
```sql
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
```

#### ```Tune```
```sql
CREATE TABLE Tune
    (TuneID             INT CONSTRAINT pk_tune PRIMARY KEY,
    RentalID            INT CONSTRAINT fk_tune_rental FOREIGN KEY REFERENCES Rental(RentalID),
    [Date]              DATE DEFAULT GETDATE() CONSTRAINT nn_tune_date NOT NULL
		CONSTRAINT ck_tune_date CHECK ([Date] < GetDate())
    );
```

#### ```TuneLine```
```sql
CREATE TABLE TuneLine
    (TuneID             INT CONSTRAINT nn_tune_line_id NOT NULL,
    TuneTypeID          NVARCHAR(50) CONSTRAINT nn_tune_line_type_id NOT NULL,
    CompletionTime      INT CONSTRAINT nn_tune_line_completion_time NOT NULL,
    CONSTRAINT pk_tune_line PRIMARY KEY (TuneID, TuneTypeID),
    CONSTRAINT fk_tune_line_tune FOREIGN KEY (TuneID) REFERENCES Tune(TuneID),
    CONSTRAINT fk_tune_line_tune_type FOREIGN KEY (TuneTypeID) REFERENCES TuneType(TuneTypeID)
    );
```