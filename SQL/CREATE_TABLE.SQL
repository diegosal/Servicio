USE [RM.DV.Core]
GO

CREATE TABLE [dbo].[CatTypeUser] (

Id 						INT IDENTITY(1,10) NOT NULL,
TypeUser 				NVARCHAR(100) NOT NULL,
CreationDate 			DATETIME NOT NULL,
ModificationDate 		DATETIME NOT NULL,
Active 					BIT NOT NULL

)
GO
ALTER TABLE [dbo].[CatTypeUser]
ADD CONSTRAINT PK_TypeUser PRIMARY KEY CLUSTERED (Id)
GO

CREATE TABLE [dbo].[CatTypeCommittee] (

Id 						INT IDENTITY(1,10) NOT NULL,
TypeCommittee 			NVARCHAR(100) NOT NULL,
CreationDate 			DATETIME NOT NULL,
ModificationDate 		DATETIME NOT NULL,
Active 					BIT NOT NULL

)
GO
ALTER TABLE [dbo].[CatTypeCommittee]
ADD CONSTRAINT PK_TypeCommittee PRIMARY KEY CLUSTERED (Id) 

CREATE TABLE [dbo].[CatTypeVisit] (

Id 					INT IDENTITY(1,10) NOT NULL,
TypeVisit 			NVARCHAR(255) NOT NULL,
CreationDate 		DATETIME NOT NULL,
ModificationDate 	DATETIME NOT NULL,
Active 				BIT NOT NULL

)
GO

ALTER TABLE [dbo].[CatTypeVisit]
ADD CONSTRAINT PK_TypeVisit PRIMARY KEY CLUSTERED (Id) 
GO

CREATE TABLE [dbo].[CatRecreationalArea] (

Id 					INT IDENTITY(1,10) NOT NULL,
AreaName 			NVARCHAR(255) NOT NULL,
CreationDate 		DATETIME NOT NULL,
ModificationDate 	DATETIME NOT NULL,
Active 				BIT NOT NULL

)
GO

ALTER TABLE [dbo].[CatRecreationalArea]
ADD CONSTRAINT PK_RecreationalArea PRIMARY KEY CLUSTERED (Id) 
GO

CREATE TABLE [dbo].[CatEventuality] (

Id 						INT IDENTITY(1,10) NOT NULL,
EventualityName 		NVARCHAR(255) NOT NULL,
CreationDate 			DATETIME NOT NULL,
ModificationDate 		DATETIME NOT NULL,
Active 					BIT NOT NULL

)
GO

ALTER TABLE [dbo].[CatEventuality]
ADD CONSTRAINT PK_Eventuality PRIMARY KEY CLUSTERED (Id) 
GO

CREATE TABLE [dbo].[CatStatus] (

Id 					INT IDENTITY(1,10) NOT NULL,
StatusName 			NVARCHAR(255) NOT NULL,
CreationDate 		DATETIME NOT NULL,
ModificationDate 	DATETIME NOT NULL,
Active 				BIT NOT NULL

)
GO

ALTER TABLE [dbo].[CatStatus]
ADD CONSTRAINT PK_Status PRIMARY KEY CLUSTERED (Id) 
GO

CREATE TABLE [dbo].[CatSupplier] (

Id 						INT IDENTITY(1,10) NOT NULL,
SupplierName			NVARCHAR(255) NOT NULL,
ContactNumer			NVARCHAR(255) NOT NULL,
CreationDate 			DATETIME NOT NULL,
ModificationDate 		DATETIME NOT NULL,
Active 					BIT NOT NULL

)
GO

ALTER TABLE [dbo].[CatSupplier]
ADD CONSTRAINT PK_Supplier PRIMARY KEY CLUSTERED (Id) 
GO

CREATE TABLE [dbo].[Company] (

Id 						INT IDENTITY(1,10) NOT NULL,
CompanyName 			NVARCHAR(255) NOT NULL,
CreationDate 			DATETIME NOT NULL,
ModificationDate 		DATETIME NOT NULL,
Active 					BIT NOT NULL

)
GO

ALTER TABLE [dbo].[Company]
ADD CONSTRAINT PK_Company PRIMARY KEY CLUSTERED (Id) 
GO

CREATE TABLE [dbo].[User] (

Id 					INT IDENTITY(1,10) NOT NULL,
CompanyId 			INT NOT NULL,
TypeId 				INT NOT NULL,
UserName 			NVARCHAR(150) NOT NULL,
UserMiddleName 		NVARCHAR(150) NOT NULL,
UserLastName 		NVARCHAR(150) NOT NULL,
UserMotherName 		NVARCHAR(150) NOT NULL,
Email 				NVARCHAR(255) NOT NULL,
PassWord 			NVARCHAR(12) NOT NULL,
CreationDate 		DATETIME NOT NULL,
ModificationDate 	DATETIME NOT NULL,
Active 				BIT NOT NULL

)
GO

ALTER TABLE [dbo].[User]
ADD CONSTRAINT PK_User PRIMARY KEY CLUSTERED (Id)
GO

ALTER TABLE [dbo].[User]
ADD CONSTRAINT FK_Company
FOREIGN KEY (CompanyId) REFERENCES [dbo].[Company](Id) 
GO

ALTER TABLE [dbo].[User]
ADD CONSTRAINT FK_TypeUser
FOREIGN KEY (TypeId) REFERENCES [dbo].[CatTypeUser](Id)  
GO

CREATE TABLE [dbo].[Vehicle] (

Id 						INT IDENTITY(1,10) NOT NULL,
UserId 					INT NOT NULL,
Plates 					NVARCHAR(50) NOT NULL,
Model 					NVARCHAR(255) NOT NULL,
CreationDate 			DATETIME NOT NULL,
ModificationDate 		DATETIME NOT NULL,
Active 					BIT NOT NULL

)
GO

ALTER TABLE [dbo].[Vehicle]
ADD CONSTRAINT PK_Vehicle PRIMARY KEY CLUSTERED (Id) 
GO

ALTER TABLE [dbo].[Vehicle]
ADD CONSTRAINT FK_Vehicle_User
FOREIGN KEY (UserId) REFERENCES [dbo].[User](Id) 
GO

CREATE TABLE [dbo].[Address] ( 

Id 					INT IDENTITY(1,10) NOT NULL,
UserId 				INT NOT NULL,
StreetName 			NVARCHAR(255) NOT NULL,
Number 				NVARCHAR(10) NOT NULL,
PostalCode 			NVARCHAR(10) NOT NULL,
CreationDate 		DATETIME NOT NULL,
ModificationDate 	DATETIME NOT NULL,
Active 				BIT NOT NULL

)
GO

ALTER TABLE [dbo].[Address]
ADD CONSTRAINT PK_Address PRIMARY KEY CLUSTERED (Id) 
GO

ALTER TABLE [dbo].[Address]
ADD CONSTRAINT FK_Address_User
FOREIGN KEY (UserId) REFERENCES [dbo].[User](Id) 
GO

CREATE TABLE [dbo].[CommitteeMember] ( 

Id 						INT IDENTITY(1,10) NOT NULL,
UserId 					INT NOT NULL,
CommitteeTypeId 		INT NOT NULL,
CreationDate 			DATETIME NOT NULL,
ModificationDate 		DATETIME NOT NULL,
Active 					BIT NOT NULL

)
GO

ALTER TABLE [dbo].[CommitteeMember]
ADD CONSTRAINT PK_Committee PRIMARY KEY CLUSTERED (Id) 
GO

ALTER TABLE [dbo].[CommitteeMember]
ADD CONSTRAINT FK_Committee_User
FOREIGN KEY (UserId) REFERENCES [dbo].[User](Id) 
GO

ALTER TABLE [dbo].[CommitteeMember]
ADD CONSTRAINT FK_TypeComittee
FOREIGN KEY (CommitteeTypeId) REFERENCES [dbo].[CatTypeCommittee](Id) 
GO

CREATE TABLE [dbo].[Event] (

Id 						INT IDENTITY(1,10) NOT NULL,
UserId 					INT NOT NULL,
RecreationalAreaId 		INT NOT NULL,
StartDate 				DATETIME NOT NULL,
EndDate 				DATETIME NOT NULL,
Status 					BIT NOT NULL

)
GO

ALTER TABLE [dbo].[Event]
ADD CONSTRAINT PK_Event PRIMARY KEY CLUSTERED (Id)
GO

ALTER TABLE [dbo].[Event]
ADD CONSTRAINT FK_Event_User
FOREIGN KEY (UserId) REFERENCES [dbo].[User](Id) 
GO

ALTER TABLE [dbo].[Event]
ADD CONSTRAINT FK_RecreationalArea
FOREIGN KEY (RecreationalAreaId) REFERENCES [dbo].[CatRecreationalArea](Id) 
GO

CREATE TABLE [dbo].[Ticket] (

Id 					INT IDENTITY(1,10) NOT NULL,
UserId 				INT NOT NULL,
EventualityId 		INT NOT NULL,
StatusId 			INT NOT NULL,
CreationDate 		DATETIME NOT NULL,
ModificationDate	DATETIME NOT NULL

)
GO

ALTER TABLE [dbo].[Ticket]
ADD CONSTRAINT PK_Ticket PRIMARY KEY CLUSTERED (Id)
GO

ALTER TABLE [dbo].[Ticket]
ADD CONSTRAINT FK_Ticket_User
FOREIGN KEY (UserId) REFERENCES [dbo].[User](Id) 
GO

ALTER TABLE [dbo].[Ticket]
ADD CONSTRAINT FK_Eventuality
FOREIGN KEY (EventualityId) REFERENCES [dbo].[CatEventuality](Id)
GO

ALTER TABLE [dbo].[Ticket]
ADD CONSTRAINT FK_Status
FOREIGN KEY (StatusId) REFERENCES [dbo].[CatStatus](Id)    
GO

CREATE TABLE [dbo].[Visit] (

Id 					INT IDENTITY(1,10) NOT NULL,
VisitId 			INT NOT NULL,
UserId 				INT NOT NULL,
CheckIn				DATETIME NOT NULL,
CheckOut 			DATETIME NOT NULL,
VisitName 			NVARCHAR(150) NOT NULL,
Carnet				NVARCHAR(250) NOT NULL,
Plates				NVARCHAR(50) NOT NULL

)
GO

ALTER TABLE [dbo].[Visit]
ADD CONSTRAINT PK_Visit PRIMARY KEY CLUSTERED (Id)
GO

ALTER TABLE [dbo].[Visit]
ADD CONSTRAINT FK_Visit_User
FOREIGN KEY (UserId) REFERENCES [dbo].[User](Id)
GO

ALTER TABLE [dbo].[Visit]
ADD CONSTRAINT FK_Visit
FOREIGN KEY (VisitId) REFERENCES [dbo].[CatTypeVisit](Id) 
GO

CREATE TABLE [dbo].[AssistControl] (

Id 					INT IDENTITY(1,10) NOT NULL,
UserId 				INT NOT NULL,
CheckIn				DATETIME NOT NULL,
CheckOut 			DATETIME NOT NULL

)
GO

ALTER TABLE [dbo].[AssistControl]
ADD CONSTRAINT PK_AssistControl PRIMARY KEY CLUSTERED (Id) 
GO

ALTER TABLE [dbo].[AssistControl]
ADD CONSTRAINT FK_Assist_User
FOREIGN KEY (UserId) REFERENCES [dbo].[User](Id) 
GO

CREATE TABLE [dbo].[Payment] (

Id 						INT IDENTITY(1,10) NOT NULL,
UserId 					INT NOT NULL,
Amount                  NUMERIC(18,0) NOT NULL,
PaymentStatus			BIT NOT NULL,
PaymentDate				DATETIME NOT NULL

)
GO

ALTER TABLE [dbo].[Payment]
ADD CONSTRAINT PK_Payment PRIMARY KEY CLUSTERED (Id) 
GO

ALTER TABLE [dbo].[Payment]
ADD CONSTRAINT FK_Payment_User
FOREIGN KEY (UserId) REFERENCES [dbo].[User](Id) 
GO

CREATE TABLE [dbo].[InternalBox] (

Amount					NUMERIC(18,0) NOT NULL, 
CreationDate 			DATETIME NOT NULL

)
GO

ALTER TABLE [dbo].[InternalBox]
ADD CONSTRAINT PK_InternalBox PRIMARY KEY (Amount, CreationDate) 
GO

CREATE TABLE [dbo].[InternalExpense] (

Id 					INT IDENTITY(1,10) NOT NULL,
UserId 				INT NOT NULL,
Amount				NUMERIC(18,0) NOT NULL,
CreationDate 		DATETIME NOT NULL

)
GO

ALTER TABLE [dbo].[InternalExpense]
ADD CONSTRAINT PK_InternalExpense PRIMARY KEY CLUSTERED (Id)
GO

ALTER TABLE [dbo].[InternalExpense]
ADD CONSTRAINT FK_Expense_User
FOREIGN KEY (UserId) REFERENCES [dbo].[User](Id)
GO