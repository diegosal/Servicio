/*--------------------------------------------------
---------Create By: Diego Gonzalez------------------
---------Creation Date: 2017-07-05------------------
---------Description: Insert Cat Supplier------------
*/--------------------------------------------------

USE [RM.DV.Core]
GO

IF OBJECT_ID('[dbo].[SYSInsCatSupplier]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSInsCatSupplier] 
END 
GO

CREATE PROCEDURE [dbo].[SYSInsCatSupplier]

	@SupplierName 		NVARCHAR(255),
	@ContactNumer		NVARCHAR(255),
	@Active				BIT

AS
	
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	INSERT INTO [dbo].[CatSupplier]
	(
		[SupplierName],
		[ContactNumer],
		[CreationDate],
		[ModificationDate],
		[Active]
	)

	SELECT

		@SupplierName,
		@ContactNumer,
		GETDATE(),
		GETDATE(),
		@Active

	COMMIT
GO

