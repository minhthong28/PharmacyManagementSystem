-- Tai Khoan
INSERT INTO users (id, userRole, name, email, username, password)
VALUES 
('U001', 'user', 'Nguyen Van An', 'an.nguyen@gmail.com', 'user1', '123'),
('U002', 'user', 'Tran Thi Binh', 'binh.tran@gmail.com', 'user2', '123'),
('U003', 'user', 'Minh Thong', '2254050064thong@gmail.com', 'user3', '123'),

('A001', 'admin', 'Pham Quang Duy', 'duy.pham@gmail.com', 'admin1', '123'),
('A002', 'admin', 'Hoang Thi Nhu', 'nhu.hoang@gmail.com', 'admin2', '123');

-- Nhan Vien
INSERT INTO employee (employeeID, name, birthDate, phoneNumber, gender, hireDate, userID)
VALUES 
('E001', 'Nguyen Van An', '2001-08-13', '0932558119', N'Nam', '2023-06-15', 'U001'),
('E002', 'Tran Thi Binh', '1999-03-15', '0932558120', N'Nữ', '2022-04-10', 'U002'),
('E003', 'Minh Thong', '2004-02-28', '0932558121', N'Nam', '2024-01-05', 'U003'),

('E004', 'Pham Quang Duy', '2005-01-10', '0932558122', N'Nam', '2023-03-01', 'A001'),
('E005', 'Hoang Thi Nhu', '2003-12-20', '0932558123', N'Nữ', '2021-11-20', 'A002');

-- Thuoc
INSERT INTO Medicine (mid, mname, mnumber, mDate, eDate, quantity, perUnit, SupplierId, employeeID, importDate) VALUES
('M001', 'Paracetamol', 'P001', '2023-01-01', '2024-03-01', 100, 5000, 'SHA001', 'E001', '2023-01-06'),
('M006', 'Loratadine', 'L006', '2024-05-01', '2026-05-01', 90, 4000, 'SHA006', 'E001', '2024-05-06'),
('M002', 'Amoxicillin', 'A002', '2023-05-10', '2024-01-15', 80, 8000, 'SUP003', 'E003', '2023-05-15'),
('M007', 'Atorvastatin', 'A007', '2024-06-15', '2025-12-31', 50, 12000, 'SUP004', 'E004', '2024-06-20'),
('M003', 'Ibuprofen', 'I003', '2022-12-12', '2023-12-31', 120, 4500, 'SHA003', 'E002', '2022-12-17'),
('M008', 'Omeprazole', 'O008', '2023-09-09', '2025-09-09', 75, 6000, 'SUP002', 'E002', '2023-09-14'),
('M009', 'Azithromycin', 'A009', '2024-07-07', '2025-07-07', 110, 9000, 'SHC005', 'E003', '2024-07-12'),
('M004', 'Ciprofloxacin', 'C004', '2023-03-03', '2024-04-01', 70, 10000, 'SUP005', 'E006', '2023-03-08'),
('M010', 'Aspirin', 'A010', '2023-02-20', '2026-02-20', 130, 2000, 'SUP006', 'E006', '2023-02-25'),
('M011', 'Dextromethorphan', 'D011', '2024-08-08', '2026-08-08', 100, 3500, 'SUP007', 'E001', '2024-08-13'),
('M005', 'Metformin', 'M005', '2022-11-11', '2024-02-28', 60, 3000, 'SUP001', 'E005', '2022-11-16'),
('M012', 'Cetirizine', 'C012', '2024-10-10', '2026-10-10', 95, 3000, 'SUP008', 'E005', '2024-10-15'),
('M013', 'Prednisone', 'P013', '2023-11-11', '2025-11-11', 85, 7500, 'SUP003', 'E002', '2023-11-16'),
('M014', 'Lisinopril', 'L014', '2024-03-03', '2025-10-10', 65, 11000, 'SUP001', 'E004', '2024-03-08'),
('M015', 'Clopidogrel', 'C015', '2024-04-04', '2025-09-30', 70, 10500, 'SHA001', 'E006', '2024-04-09'),
('M016', 'Simvastatin', 'S016', '2023-06-06', '2026-01-01', 90, 9500, 'SUP002', 'E003', '2023-06-11'),
('M017', 'Hydrochlorothiazide', 'H017', '2024-01-01', '2025-12-12', 55, 4000, 'SUP005', 'E005', '2024-01-06'),
('M018', 'Gabapentin', 'G018', '2024-02-02', '2026-03-03', 75, 8500, 'SUP004', 'E001', '2024-02-07'),
('M019', 'Levothyroxine', 'L019', '2023-07-07', '2025-07-07', 80, 9500, 'SHA003', 'E002', '2023-07-12'),
('M020', 'Naproxen', 'N020', '2024-09-09', '2026-09-09', 100, 7000, 'SUP006', 'E004', '2024-09-14');

-- Nha Cung Cap
INSERT INTO Supplier (SupplierID, SupplierName, Email, Contact, DrugsAvailable)
VALUES
('SUP001', N'Công ty Dược ABC', 'duoc.abc@gmail.com', '0912345678', N'Paracetamol, Amoxicillin'),
('SUP002', N'Nhà Thuốc Số 1', 'nhathuoc1@gmail.com', '0901234567', N'Ivermectin, Vitamin C'),
('SUP003', N'Dược Phẩm Hòa Bình', 'hoabinh.duoc@gmail.com', '0988765432', N'Dexamethasone, Cefuroxime'),
('SUP004', N'PharmaTech Việt Nam', 'pharmatech.vn@gmail.com', '0934567890', N'Insulin, Metformin'),
('SUP005', N'Công ty Thiên Phúc', 'thienphuc.duoc@gmail.com', '0978123456', N'Omeprazole, Clarithromycin'),
('SUP006', N'Dược Việt Mỹ', 'vietmy.duoc@gmail.com', '0922334455', N'Aspirin, Diazepam'),
('SUP007', N'Dược Phẩm Hòa Bình 2', 'thongluong@gmail.com', '0988764432', N'Vitamin D, Vitamin E'),
('SUP008', N'Dược Phẩm Cao Tấn', 'tancao122@gmail.com', '0988765412', N'Dexamethasone, Panadol');