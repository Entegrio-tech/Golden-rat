USE AutomationAccountingEquipment

CREATE TABLE Requests
(
	ID INT PRIMARY KEY IDENTITY,
	EmployeeID SMALLINT REFERENCES Employee (ID),
	EquipmentID NVARCHAR(10) REFERENCES Equipment (ID),
	Title NVARCHAR(100),
	Text NVARCHAR(1000),
    HostID SMALLINT REFERENCES Employee (ID),
	RequestDate DATE,
	Status BIT
);

