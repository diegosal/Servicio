/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Update Cat Payment Status-
*/----------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSUpdCatPaymentStatus]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSUpdCatPaymentStatus] 
END 
GO

CREATE PROC [dbo].[SYSUpdCatPaymentStatus] 
    
    @Id INT,
    @StatusName nvarchar(255)

AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[CatPaymentStatus] SET
		[StatusName] = @StatusName,
		[ModificationDate] = GETDATE()
	WHERE  [Id] = @Id

	COMMIT
GO