CREATE Database AddressBook_Ado
USE AddressBook_Ado;

CREATE TABLE AddressBookList(
Firstname VARCHAR(20) NOT NULL,
Lastnames VARCHAR(20)NOT NULL,
Address VARCHAR(50),
City VARCHAR(15)NOT NULL,
State VARCHAR(15)NOT NULL,
Zip BIGINT,
Phonenumber VARCHAR(10),
Email VARCHAR(20)NOT NULL
);
SELECT * FROM AddressBookList

--Insert new contact
INSERT INTO AddressBookList VALUES('Snehal','Bansod','Plotno12','Sindewahi','Maha',234523,'9877688788','snehal@gmail'),
('Mayur','Ramtake','Plot no 3','Nagpur','Maha',232424,'8787667886','mayur@gmail'),('Lata','Bhakare','Plot no7','Chamorshi','UP',546354,'9345678912','lata@gmail'),
('Raju','Borkar','Plotno31','Nagpur','MP',232423,'8787567486','raju@gmail'),('Latatai','Bhange','Plotno73','Chamorshi','UP',546351,'8345678912','latatai@gmail');

