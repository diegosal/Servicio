/*----------------------------------------------------
---------Create By: Diego Gonzalez--------------------
---------Creation Date: 2017-07-05--------------------
---------Description: Insert new Company--------------
*/----------------------------------------------------



USE [RM.DV.Core]
GO

DROP PROCEDURE IF EXISTS [dbo].[SYSInsertCompany]
GO

CREATE PROCEDURE [dbo].[SYSInsertCompany]

	@CompanyName 		NVARCHAR(255),
	@Active				BIT

AS

	INSERT INTO [dbo].[Company]
	(
        CompanyName,
		CreationDate,
		ModificationDate,
		Active
	)

	VALUES
	(
		@CompanyName,
		GETDATE(),
		GETDATE(),
		@Active
	)

GO

