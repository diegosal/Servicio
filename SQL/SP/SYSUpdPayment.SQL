/*-------------------------------------------------
---------Create By: Diego Gonzalez-----------------
---------Creation Date: 2017-07-05-----------------
---------Description: Update Payment---------------
*/-------------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSUpdPayment]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSUpdPayment] 
END 
GO

CREATE PROC [dbo].[SYSUpdPayment] 
    
    @Id 				INT,
    @PaymentStatus 		INT

AS

	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Payment] SET
		[PaymentStatusId] = @PaymentStatus
	WHERE  [Id] = @Id

	COMMIT
GO