/*----------------------------------------------------
---------Create By: Diego Gonzalez--------------------
---------Creation Date: 2017-07-05--------------------
---------Description: Insert new Company--------------
*/----------------------------------------------------

USE [RM.DV.Core]
GO

IF OBJECT_ID('[dbo].[SYSInsCompany]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSInsCompany] 
END 
GO

CREATE PROCEDURE [dbo].[SYSInsCompany]

	@CompanyName 		NVARCHAR(255),
	@Active				BIT

AS
	
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	INSERT INTO [dbo].[Company]
	(
        [CompanyName],
		[CreationDate],
		[ModificationDate],
		[Active]
	)

	SELECT

		@CompanyName,
		GETDATE(),
		GETDATE(),
		@Active

	COMMIT
GO

