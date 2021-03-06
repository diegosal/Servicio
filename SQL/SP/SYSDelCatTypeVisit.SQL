/*-------------------------------------------------
---------Create By: Diego Gonzalez-----------------
---------Creation Date: 2017-07-05-----------------
---------Description: Delete Cat Type Visit--------
*/-------------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSDelCatTypeVisit]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSDelCatTypeVisit] 
END 
GO

CREATE PROC [dbo].[SYSDelCatTypeVisit] 
    
    @Id			INT

AS 

	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[CatTypeVisit]	SET
		[Active] = 0,
		[ModificationDate] = GETDATE()
	WHERE  [Id] = @Id

	COMMIT
GO