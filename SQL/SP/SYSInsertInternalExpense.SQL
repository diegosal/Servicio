/*----------------------------------------------------
---------Create By: Diego Gonzalez--------------------
---------Creation Date: 2017-07-05--------------------
---------Description: Insert new Internal Expense-----
*/----------------------------------------------------



USE [RM.DV.Core]
GO

DROP PROCEDURE IF EXISTS [dbo].[SYSInsertInternalExpense]
GO

CREATE PROCEDURE [dbo].[SYSInsertInternalExpense]

	@UserId 			INT,
	@Amount 			NUMERIC(18,0)

AS

	INSERT INTO [dbo].[InternalExpense]
	(
		UserId,
		Amount,
		CreationDate
	)
	VALUES
	(
		@UserId,
		@Amount,
		GETDATE()
	)

GO

