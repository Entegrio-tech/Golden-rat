USE AutomationAccountingEquipment;

CREATE TABLE Equipment 
(
	ID INT IDENTITY NOT NULL,
	Name NVARCHAR(50) NOT NULL,
	Type NVARCHAR(20),
	EmployeeID INT,
	Location NVARCHAR(40),
	Components NVARCHAR(1000),
	PRIMARY KEY(ID),
	FOREIGN KEY(EmployeeID) REFERENCES Employee (ID)
);