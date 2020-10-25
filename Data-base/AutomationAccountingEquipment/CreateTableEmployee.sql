USE AutomationAccountingEquipment;

CREATE TABLE Employee
(
  ID SMALLINT IDENTITY NOT NULL,
  FirstName NVARCHAR(20),
  LastName NVARCHAR(20),
  Email NVARCHAR(30) UNIQUE,
  Login NVARCHAR(20),
  Password VARBINARY(60),
  Privilage BIT,
  PRIMARY KEY (id)
);
