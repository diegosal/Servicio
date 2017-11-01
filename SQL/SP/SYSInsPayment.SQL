/*----------------------------------------------------
---------Create By: Diego Gonzalez--------------------
---------Creation Date: 2017-07-05--------------------
---------Description: Insert new Payment--------------
*/----------------------------------------------------

USE [RM.DV.Core]
GO

IF OBJECT_ID('[dbo].[SYSInsPayment]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSInsPayment] 
END 
GO

CREATE PROCEDURE [dbo].[SYSInsPayment]

	@UserId 			INT,
	@Amount 			NUMERIC(18,0),
	@PaymentStatus 		INT 

AS 

	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	INSERT INTO [dbo].[Payment]
	(
		[UserId],
		[Amount],
		[PaymentStatusId],
		[PaymentDate]
	)

	SELECT

		@UserId,
		@Amount,
		@PaymentStatus,
		GETDATE()
	
	COMMIT
GO

