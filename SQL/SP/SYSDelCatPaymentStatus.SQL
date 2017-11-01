/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Delete Cat Payment Status-
*/----------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSDelCatPaymentStatus]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSDelCatPaymentStatus] 
END 
GO

CREATE PROC [dbo].[SYSDelCatPaymentStatus] 
    
    @Id INT

AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON

	BEGIN TRAN

	UPDATE [dbo].[SYSDelCatPaymentStatus] SET
		Active = 0,
        ModificationDate = GETDATE()
   	WHERE  [Id] = @Id

   	COMMIT
GO