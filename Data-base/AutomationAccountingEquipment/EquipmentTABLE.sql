USE AutomationAccountingEquipment;

CREATE TABLE Equipment 
(
	ID SMALLINT NOT NULL,
	Name NVARCHAR(50) NOT NULL,
	Type NVARCHAR(20),
	EmployeeID SMALLINT,
	Location NVARCHAR(40),
	Inventory_number NVARCHAR(30),
	Components NVARCHAR(1000),
	PRIMARY KEY(ID),
	FOREIGN KEY(EmployeeID) REFERENCES Employee (ID),
);