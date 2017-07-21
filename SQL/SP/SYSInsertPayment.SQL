/*----------------------------------------------------
---------Create By: Diego Gonzalez--------------------
---------Creation Date: 2017-07-05--------------------
---------Description: Insert new Payment--------------
*/----------------------------------------------------


USE [RM.DV.Core]
GO

DROP PROCEDURE IF EXISTS [dbo].[SYSInsertPayment]
GO

CREATE PROCEDURE [dbo].[SYSInsertPayment]

	@UserId 			INT,
	@Amount 			NUMERIC(18,0),
	@PaymentStatus 		INT 

AS

	INSERT INTO [dbo].[Payment]
	(
		UserId,
		Amount,
		PaymentStatus,
		PaymentDate
	)
	VALUES
	(
		@UserId,
		@Amount,
		@PaymentStatus,
		GETDATE()
	)

GO

