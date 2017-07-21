/*--------------------------------------------------
---------Create By: Diego Gonzalez------------------
---------Creation Date: 2017-07-05------------------
---------Description: Insert Status-----------------
*/--------------------------------------------------



USE [RM.DV.Core]
GO

DROP PROCEDURE IF EXISTS [dbo].[SYSInsertCatSupplier]
GO

CREATE PROCEDURE [dbo].[SYSInsertCatSupplier]

	@SupplierName 		NVARCHAR(255),
	@ContactNumer		NVARCHAR(255),
	@Active				BIT

AS

	INSERT INTO [dbo].[CatSupplier]
	(
		SupplierName,
		ContactNumer,
		CreationDate,
		ModificationDate,
		Active
	)

	VALUES
	(
		@SupplierName,
		@ContactNumer,
		GETDATE(),
		GETDATE(),
		@Active
	)

GO

