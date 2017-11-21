/*-------------------------------------------------
---------Create By: Diego Gonzalez-----------------
---------Creation Date: 2017-07-05-----------------
---------Description: Delete Cat Supplier----------
*/-------------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSDelCatSupplier]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSDelCatSupplier] 
END 
GO

CREATE PROC [dbo].[SYSDelCatSupplier] 
    
    @Id  			INT

AS

	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[CatSupplier] SET
		[Active] = 0,
		[ModificationDate] = GETDATE()
	WHERE  [Id] = @Id
	
	COMMIT
GO