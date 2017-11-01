/*--------------------------------------------------
---------Create By: Diego Gonzalez------------------
---------Creation Date: 2017-07-05------------------
---------Description: Insert Cat Payment Status-----
*/--------------------------------------------------

USE [RM.DV.Core]
GO

IF OBJECT_ID('[dbo].[SYSInsCatPaymentStatus]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSInsCatPaymentStatus] 
END 
GO

CREATE PROCEDURE [dbo].[SYSInsCatPaymentStatus]

	@StatusName		NVARCHAR(255),
	@Active			BIT

AS
	
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	INSERT INTO [dbo].[CatPaymentStatus]
	(
		[StatusName],
		[CreationDate],
		[ModificationDate],
		[Active]
	)
	
	SELECT

		@StatusName,
		GETDATE(),
		GETDATE(),
		@Active

	COMMIT
	
GO

