/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Get Cat Supplier----------
*/----------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSGetCatSupplier]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSGetCatSupplier] 
END 
GO

CREATE PROC [dbo].[SYSGetCatSupplier] 
    
    @Id INT

AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT

		[Id],
		[SupplierName],
		[ContactNumer],
		[CreationDate],
		[ModificationDate],
		[Active]

	FROM   [dbo].[CatSupplier] 
	WHERE  ([Id] = @Id OR @Id IS NULL) 

	COMMIT
GO