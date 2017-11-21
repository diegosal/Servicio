/*-------------------------------------------------
---------Create By: Diego Gonzalez-----------------
---------Creation Date: 2017-07-05-----------------
---------Description: Delete Company---------------
*/-------------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSDelCompany]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSDelCompany] 
END 
GO

CREATE PROC [dbo].[SYSDelCompany] 
    
    @Id INT

AS 

	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Company] SET
		[Active] = 0,
		[ModificationDate] = GETDATE()
	WHERE  [Id] = @Id

	COMMIT
GO