/*-------------------------------------------------
---------Create By: Diego Gonzalez-----------------
---------Creation Date: 2017-07-05-----------------
---------Description: Delete Cat Type User---------
*/-------------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSDelCatTypeUser]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSDelCatTypeUser] 
END 
GO

CREATE PROC [dbo].[SYSDelCatTypeUser] 
    
    @Id INT
    
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[CatTypeUser] SET
		[Active] = 0,
		[ModificationDate] = GETDATE()
	WHERE  [Id] = @Id

	COMMIT
GO