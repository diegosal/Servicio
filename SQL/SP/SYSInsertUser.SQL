/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Insert new User-----------
*/----------------------------------------------



USE [RM.DV.Core]
GO

DROP PROCEDURE IF EXISTS [dbo].[SYSInsertUser]
GO

CREATE PROCEDURE [dbo].[SYSInsertUser]

	@CompanyId        INT,
	@TypeId           INT,
	@UserName         NVARCHAR(150),
	@UserMiddleName   NVARCHAR(150),
	@UserLastName     NVARCHAR(150),
	@UserMotherName   NVARCHAR(150),
	@Email            NVARCHAR(255),
	@PassWord         NVARCHAR(MAX),
	@PassWordSalt	  NVARCHAR(32),
	@Active           BIT 

AS

	INSERT INTO [dbo].[User]
	
	(
		CompanyId,
		TypeId,
		UserName,
		UserMiddleName,
		UserLastName,
		UserMotherName,
		Email,
		PassWord,
		PassWordSalt,
		CreationDate,
		ModificationDate,
		Active
	)

	VALUES
	
	(
		@CompanyId,
		@TypeId,
		@UserName,
		@UserMiddleName,
		@UserLastName,
		@UserMotherName,
		@Email,
		@PassWord,
		@PassWordSalt,
		GETDATE(),
		GETDATE(),
		@Active
	)
	
GO

