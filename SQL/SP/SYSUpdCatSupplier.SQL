/*-------------------------------------------------
---------Create By: Diego Gonzalez-----------------
---------Creation Date: 2017-07-05-----------------
---------Description: Update Cat Supplier----------
*/-------------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSUpdCatSupplier]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSUpdCatSupplier] 
END 
GO

CREATE PROC [dbo].[SYSUpdCatSupplier] 
    
    @Id  			INT,
    @SupplierName 	NVARCHAR(255),
    @ContactNumer 	NVARCHAR(255),
    @Active 		BIT

AS

	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[CatSupplier] SET
		[SupplierName] = @SupplierName,
		[ContactNumer] = @ContactNumer,
		[ModificationDate] = GETDATE()
	WHERE  [Id] = @Id
	
	COMMIT
GO