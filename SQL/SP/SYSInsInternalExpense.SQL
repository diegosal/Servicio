/*----------------------------------------------------
---------Create By: Diego Gonzalez--------------------
---------Creation Date: 2017-07-05--------------------
---------Description: Insert new Internal Expense-----
*/----------------------------------------------------

USE [RM.DV.Core]
GO

IF OBJECT_ID('[dbo].[SYSInsInternalExpense]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSInsInternalExpense] 
END 
GO

CREATE PROCEDURE [dbo].[SYSInsInternalExpense]

	@UserId 			INT,
	@Amount 			NUMERIC(18,0)

AS

	INSERT INTO [dbo].[InternalExpense]
	(
		[UserId],
		[Amount],
		[CreationDate]
	)

	SELECT

		@UserId,
		@Amount,
		GETDATE()
	
	COMMIT
GO

