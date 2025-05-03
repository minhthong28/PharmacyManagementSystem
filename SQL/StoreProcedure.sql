-- ======== THÊM NCC =======
CREATE PROCEDURE AddSupplier
    @SupplierID NVARCHAR(20),
    @SupplierName NVARCHAR(100),
    @Email NVARCHAR(100),
    @Contact VARCHAR(15),
    @DrugsAvailable NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    -------- Kiểm tra mã NCC --------
    IF EXISTS (SELECT 1 FROM Supplier WHERE SupplierID = @SupplierID)
    BEGIN
        RAISERROR(N'Mã nhà cung cấp đã tồn tại.', 16, 1);
        RETURN;
    END
    --
    IF LEN(@SupplierID) < 6 OR @SupplierID NOT LIKE '%[A-Za-z]%' OR @SupplierID NOT LIKE '%[0-9]%'
    BEGIN
        RAISERROR(N'Mã nhà cung cấp phải có ít nhất 6 ký tự và bao gồm cả chữ và số.', 16, 1);
        RETURN;
    END

    -------- Kiểm tra tên NCC ------
    IF LEN(@SupplierName) < 6
    BEGIN
        RAISERROR(N'Tên nhà cung cấp phải có ít nhất 6 ký tự.', 16, 1);
        RETURN;
    END

    -------- Kiểm tra email ------
    IF @Email NOT LIKE '_%@_%._%'
    BEGIN
        RAISERROR(N'Email không đúng định dạng.', 16, 1);
        RETURN;
    END

    -------- Kiểm tra SĐT ------
    IF LEN(@Contact) < 10 OR LEN(@Contact) > 12 OR @Contact LIKE '%[^0-9]%'
    BEGIN
        RAISERROR(N'Số điện thoại phải có từ 10 đến 12 chữ số.', 16, 1);
        RETURN;
    END

    -------- Kiểm tra Thuốc ------
    IF LEN(LTRIM(RTRIM(@DrugsAvailable))) = 0
    BEGIN
        RAISERROR(N'Thông tin thuốc cung cấp không được để trống.', 16, 1);
        RETURN;
    END

    INSERT INTO Supplier (SupplierID, SupplierName, Email, Contact, DrugsAvailable)
    VALUES (@SupplierID, @SupplierName, @Email, @Contact, @DrugsAvailable)
END

use  PharmacyManagement

-- ======== CẬP NHẬT NCC =======
CREATE PROCEDURE sp_UpdateSupplier
    @SupplierID NVARCHAR(20),
    @SupplierName NVARCHAR(100),
    @Email NVARCHAR(100),
    @Contact VARCHAR(15),
    @DrugsAvailable NVARCHAR(255)
AS
BEGIN

    IF LEN(@SupplierName) < 6
    BEGIN
        RAISERROR(N'Tên nhà cung cấp phải từ 6 ký tự trở lên.', 16, 1);
        RETURN;
    END

    IF @Email NOT LIKE '_%@_%._%'
    BEGIN
        RAISERROR('Email không đúng định dạng.', 16, 1);
        RETURN;
    END

    IF LEN(@Contact) < 10 OR LEN(@Contact) > 12 OR @Contact LIKE '%[^0-9]%'
    BEGIN
        RAISERROR('Số liên hệ phải từ 10 đến 12 chữ số.', 16, 1);
        RETURN;
    END

    IF @DrugsAvailable IS NULL OR LTRIM(RTRIM(@DrugsAvailable)) = ''
    BEGIN
        RAISERROR(N'Thuốc cung cấp không được bỏ trống.', 16, 1);
        RETURN;
    END

    UPDATE Supplier
    SET SupplierName = @SupplierName,
        Email = @Email,
        Contact = @Contact,
        DrugsAvailable = @DrugsAvailable
    WHERE SupplierID = @SupplierID
END

-- ======== XÓA NCC =======
CREATE PROCEDURE sp_DeleteSupplier
    @SupplierID NVARCHAR(50)
AS
BEGIN
    DELETE FROM Supplier
    WHERE SupplierID = @SupplierID
END


--====== Thêm NV =====
CREATE PROCEDURE sp_AddEmployee
    @EmployeeID VARCHAR(50),
    @Name NVARCHAR(100),
    @BirthDate DATE,
    @PhoneNumber VARCHAR(15),
    @Gender NVARCHAR(10),
    @HireDate DATE,
    @UserID VARCHAR(50)
AS
BEGIN
    -- Mã NV
    IF EXISTS (SELECT 1 FROM Employee WHERE employeeID = @EmployeeID)
    BEGIN
        RAISERROR(N'Mã nhân viên đã tồn tại!', 16, 1)
        RETURN
    END

    IF (@EmployeeID NOT LIKE '%[A-Za-z]%') OR (@EmployeeID NOT LIKE '%[0-9]%')
    BEGIN
        RAISERROR(N'Mã nhân viên phải chứa cả chữ và số!', 16, 1)
        RETURN
    END

    -- Tên NV
    IF (LEN(@Name) < 6)
    BEGIN
        RAISERROR(N'Tên phải từ 6 ký tự trở lên!', 16, 1)
        RETURN
    END

    -- SĐT 
    IF (LEN(@PhoneNumber) < 10 OR LEN(@PhoneNumber) > 12 OR @PhoneNumber LIKE '%[^0-9]%')
    BEGIN
        RAISERROR(N'Số điện thoại phải từ 10 đến 12 số!', 16, 1)
        RETURN
    END

    -- DOB và HireDate
    IF (@BirthDate = @HireDate)
    BEGIN
        RAISERROR(N'Ngày sinh và ngày vào làm không được giống nhau!', 16, 1)
        RETURN
    END

    -- Giới tính 
    IF (@Gender IS NULL OR LTRIM(RTRIM(@Gender)) = '')
    BEGIN
        RAISERROR(N'Vui lòng chọn giới tính!', 16, 1)
        RETURN
    END

    -- Mã TK
    IF NOT EXISTS (SELECT 1 FROM users WHERE id = @UserID)
    BEGIN
        RAISERROR(N'Mã tài khoản không tồn tại. Vui lòng kiểm tra lại!', 16, 1)
        RETURN
    END

	IF EXISTS (SELECT 1 FROM Employee WHERE userID = @UserID)
    BEGIN
        RAISERROR(N'Mã tài khoản đã được đăng ký thông tin. Vui lòng kiểm tra lại!', 16, 1)
        RETURN
    END

    INSERT INTO Employee (employeeID, name, birthDate, phoneNumber, gender, hireDate, userID)
    VALUES (@EmployeeID, @Name, @BirthDate, @PhoneNumber, @Gender, @HireDate, @UserID)
END

--====== Xóa NV =====
CREATE PROCEDURE sp_DeleteEmployee
    @employeeID VARCHAR(50)
AS
BEGIN
    DELETE FROM Employee
	WHERE employeeID = @employeeID;
END

CREATE PROCEDURE sp_UpdateEmployee
    @EmployeeID VARCHAR(50),
    @Name NVARCHAR(100),
    @BirthDate DATE,
    @PhoneNumber VARCHAR(15),
    @Gender NVARCHAR(10),
    @HireDate DATE,
    @UserID VARCHAR(50)
AS
BEGIN
   -- Tên NV
    IF (LEN(@Name) < 6)
    BEGIN
        RAISERROR(N'Tên phải từ 6 ký tự trở lên!', 16, 1)
        RETURN
    END

    -- SĐT 
    IF (LEN(@PhoneNumber) < 10 OR LEN(@PhoneNumber) > 12 OR @PhoneNumber LIKE '%[^0-9]%')
    BEGIN
        RAISERROR(N'Số điện thoại phải từ 10 đến 12 số!', 16, 1)
        RETURN
    END

    -- DOB và HireDate
    IF (@BirthDate = @HireDate)
    BEGIN
        RAISERROR(N'Ngày sinh và ngày vào làm không được giống nhau!', 16, 1)
        RETURN
    END

    -- Giới tính 
    IF (@Gender IS NULL OR LTRIM(RTRIM(@Gender)) = '')
    BEGIN
        RAISERROR(N'Vui lòng chọn giới tính!', 16, 1)
        RETURN
    END

    -- Mã TK
    IF NOT EXISTS (SELECT 1 FROM users WHERE id = @UserID)
    BEGIN
        RAISERROR(N'Mã tài khoản không tồn tại. Vui lòng kiểm tra lại!', 16, 1)
        RETURN
    END

	IF EXISTS (SELECT 1 FROM Employee WHERE userID = @UserID AND employeeID != @EmployeeID)
    BEGIN
        RAISERROR(N'Mã tài khoản đã được đăng ký thông tin. Vui lòng kiểm tra lại!', 16, 1)
        RETURN
    END

--====== Cập Nhật NV =====
    UPDATE employee
    SET name = @Name,
        birthDate = @BirthDate,
        phoneNumber = @PhoneNumber,
        gender = @Gender,
        hireDate = @HireDate,
        userID = @UserID
    WHERE employeeID = @EmployeeID
END

   



