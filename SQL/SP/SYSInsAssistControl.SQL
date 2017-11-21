/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Insert new Assist Control-
*/----------------------------------------------

USE [RM.DV.Core]
GO

IF OBJECT_ID('[dbo].[SYSInsAssistControl]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSInsAssistControl] 
END 
GO

CREATE PROC [dbo].[SYSInsAssistControl] 

	@UserId	 INT

AS

	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	INSERT INTO [dbo].[AssistControl]
	(
		[UserId],
		[CheckIn],
		[CheckOut]
	)

	SELECT 
		@UserId,
		GETDATE(),
		GETDATE()

	COMMIT
GO

