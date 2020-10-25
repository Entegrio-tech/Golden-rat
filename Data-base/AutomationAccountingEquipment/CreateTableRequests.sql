USE AutomationAccountingEquipment

CREATE TABLE Requests
(
	ID SMALLINT PRIMARY KEY IDENTITY,
	EmployeeID SMALLINT REFERENCES Employee (ID),
	EquipmentID NVARCHAR(8) REFERENCES Equipment (ID),
	Text NVARCHAR(1000),
    	Title NVARCHAR(100),
    	HostID SMALLINT REFERENCES Employee (ID),
	RequestDate DATE,
	Status BIT
);

