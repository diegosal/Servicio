/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Insert new User-----------
*/----------------------------------------------

USE [RM.DV.Core]
GO

IF OBJECT_ID('[dbo].[SYSInsUser]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSInsUser] 
END 
GO

CREATE PROCEDURE [dbo].[SYSInsUser]

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

	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	INSERT INTO [dbo].[User]
	
	(
		[CompanyId],
		[TypeId],
		[UserName],
		[UserMiddleName],
		[UserLastName],
		[UserMotherName],
		[Email],
		[PassWord],
		[PassWordSalt],
		[CreationDate],
		[ModificationDate],
		[Active]
	)

	SELECT

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
	
	COMMIT
GO

