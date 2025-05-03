use master

create database PharmacyManagement

use PharmacyManagement

-- Tai Khoan
CREATE TABLE users (
    id varchar(50) PRIMARY KEY,           
    userRole varchar(50) NOT NULL,
    name varchar(250) NOT NULL,
    email varchar(250) NOT NULL,
    username varchar(250) UNIQUE NOT NULL,
    password varchar(250) NOT NULL
);
-- Nhan Vien
CREATE TABLE Employee (
    employeeID VARCHAR(50) PRIMARY KEY,            
    name NVARCHAR(100) NOT NULL,                  
    birthDate DATE NOT NULL,                       
    phoneNumber VARCHAR(15) NOT NULL,          
    gender NVARCHAR(10) NOT NULL,                 
    hireDate DATE NOT NULL,                       
    userID VARCHAR(50) NOT NULL,                 
    FOREIGN KEY (userID) REFERENCES users(id)      
);

-- Thuoc
CREATE TABLE Medicine (
    mid VARCHAR(250) PRIMARY KEY,
    mname VARCHAR(250) NOT NULL,
    mnumber VARCHAR(250) NOT NULL,
    mDate VARCHAR(250) NOT NULL,
    eDate VARCHAR(250) NOT NULL,
    quantity BIGINT NOT NULL,
    perUnit BIGINT NOT NULL,
    SupplierId NVARCHAR(20),
    employeeID VARCHAR(50),
    importDate VARCHAR(250) NOT NULL,
    CONSTRAINT FK_medicine_Supplier FOREIGN KEY (SupplierId) REFERENCES Supplier(SupplierID),
    CONSTRAINT FK_medicine_Employee FOREIGN KEY (employeeID) REFERENCES Employee(employeeID)
);

-- Nha Cung Cap
CREATE TABLE Supplier (
    SupplierID NVARCHAR(20) PRIMARY KEY,      
    SupplierName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    Contact VARCHAR(15) NOT NULL,             
    DrugsAvailable NVARCHAR(255) NOT NULL
);

-- Don Dat Hang Nha Cung Cap
CREATE TABLE Orders (
    OrderID VARCHAR(20) PRIMARY KEY,              
    EmployeeID VARCHAR(50) NOT NULL,              
    MNumber VARCHAR(250) NOT NULL,                
    MedicineName NVARCHAR(250) NOT NULL,         
    Quantity INT NOT NULL,                        
    OrderDate DATE NOT NULL DEFAULT GETDATE(),    
    SupplierName NVARCHAR(100) NOT NULL,          
    SupplierEmail NVARCHAR(100) NOT NULL,         

    CONSTRAINT FK_Orders_Employee FOREIGN KEY (EmployeeID) REFERENCES Employee(employeeID)
);

-- Hoa Don Ban Hang
CREATE TABLE Invoice (
    InvoiceID VARCHAR(10) PRIMARY KEY,
    InvoiceDate DATE NOT NULL,
    TotalAmount DECIMAL(18, 2) NOT NULL,
    employeeID VARCHAR(50),
    CONSTRAINT FK_Invoice_Employee FOREIGN KEY (employeeID) REFERENCES Employee(employeeID)
);

-- Chi Tiet Hoa Don
CREATE TABLE InvoiceDetail (
    InvoiceDetailID INT IDENTITY PRIMARY KEY,
    InvoiceID VARCHAR(10),
    MedicineID NVARCHAR(250),
    MedicineName NVARCHAR(100),
    Quantity INT,
    UnitPrice BIGINT,
    Total BIGINT,
	CONSTRAINT FK_InvoiceDetail_Medicine FOREIGN KEY (MedicineID) REFERENCES Medicine(mid),
    FOREIGN KEY (InvoiceID) REFERENCES Invoice(InvoiceID)
);



