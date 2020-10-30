USE AutomationAccountingEquipment

CREATE TABLE Requests
(
	ID INT PRIMARY KEY IDENTITY,
	EmployeeID INT REFERENCES Employee (ID),
	EquipmentID INT REFERENCES Equipment (ID),
	Text NVARCHAR(1000),
    Title NVARCHAR(100),
    HostID INT REFERENCES Employee (ID),
	RequestDate DATE,
	Status BIT
);

