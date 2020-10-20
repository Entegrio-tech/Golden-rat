USE AutomationAccountingEquipment

CREATE TABLE Requests
(
	ID SMALLINT PRIMARY KEY IDENTITY,
	EmployeeID SMALLINT REFERENCES Employee (id),
	EquipmentID SMALLINT REFERENCES Equipment (ID),
	Text NVARCHAR(500),
    HostID SMALLINT REFERENCES Employee (id),
	RequestDate DATE
);

