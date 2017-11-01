/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Get Assist Control--------
*/----------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSGetAssistControl]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSGetAssistControl] 
END 
GO

CREATE PROC [dbo].[SYSGetAssistControl] 
    @Id int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT 

		[Id],
		[UserId],
		[CheckIn],
		[CheckOut]

	FROM   [dbo].[AssistControl] 
	WHERE  ([Id] = @Id OR @Id IS NULL)

	COMMIT
GO