USE AutomationAccountingEquipment;

CREATE TABLE Employee
(
  id SMALLINT,
  FirstName NVARCHAR(20),
  LastName NVARCHAR(20),
  Phone VARCHAR(20),
  Login VARCHAR(20),
  Password VARBINARY(30),
  Privilage bit,
  PRIMARY KEY (id)
  );
