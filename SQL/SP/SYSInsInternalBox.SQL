/*----------------------------------------------------
---------Create By: Diego Gonzalez--------------------
---------Creation Date: 2017-07-05--------------------
---------Description: Insert new Internal Box---------
*/----------------------------------------------------

USE [RM.DV.Core]
GO

IF OBJECT_ID('[dbo].[SYSInsInternalBox]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSInsInternalBox] 
END 
GO

CREATE PROCEDURE [dbo].[SYSInsInternalBox]

	@Amount		NUMERIC(18,0)

AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	INSERT INTO [dbo].[InternalBox]
	(
		[Amount],
		[CreationDate]
    )

	SELECT
	
		@Amount,
		GETDATE()

	COMMIT
GO

