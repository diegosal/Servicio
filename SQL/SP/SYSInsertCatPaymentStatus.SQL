/*--------------------------------------------------
---------Create By: Diego Gonzalez------------------
---------Creation Date: 2017-07-05------------------
---------Description: Insert PaymentStatus----------
*/--------------------------------------------------



USE [RM.DV.Core]
GO

DROP PROCEDURE IF EXISTS [dbo].[SYSInsertCatPaymentStatus]
GO

CREATE PROCEDURE [dbo].[SYSInsertCatPaymentStatus]

	@StatusName		NVARCHAR(255),
	@Active			BIT

AS

	INSERT INTO [dbo].[CatPaymentStatus]
	(
		StatusName,
		CreationDate,
		ModificationDate,
		Active
	)
	VALUES
	(
		@StatusName,
		GETDATE(),
		GETDATE(),
		@Active
	)

GO

