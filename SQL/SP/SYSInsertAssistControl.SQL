/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Insert new Assist Control-
*/----------------------------------------------



USE [RM.DV.Core]
GO

DROP PROCEDURE IF EXISTS [dbo].[SYSInsertAssistControl]
GO

CREATE PROCEDURE [dbo].[SYSInsertAssistControl]

	@UserId	 INT

AS

	INSERT INTO [dbo].[AssistControl]
	(
		UserId,
		CheckIn,
		CheckOut
	)

	VALUES
	(
		@UserId,
		GETDATE(),
		GETDATE()
	)

GO

