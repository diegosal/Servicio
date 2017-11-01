/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Update Assist Control-----
*/----------------------------------------------

USE [RM.DV.Core]
GO

IF OBJECT_ID('[dbo].[SYSUpdAssistControl]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSUpdAssistControl] 
END 
GO

CREATE PROCEDURE [dbo].[SYSUpdAssistControl]

	@UserId	 INT

AS
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	DECLARE @AssistId AS INT
	DECLARE @CheckIn AS DATETIME

	SELECT TOP 1 @AssistId = Id,  @CheckIn = MAX(CheckIn) 
	FROM [dbo].[AssistControl] 
	WHERE UserId = @UserId 
	GROUP BY Id ORDER BY Id DESC

	BEGIN TRAN

	UPDATE [dbo].[AssistControl] SET
		CheckOut = GETDATE()
	WHERE Id = @AssistId

	COMMIT
GO