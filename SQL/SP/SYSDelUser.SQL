/*-------------------------------------------------
---------Create By: Diego Gonzalez-----------------
---------Creation Date: 2017-07-05-----------------
---------Description: Delete User-----------------
*/-------------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSDelUser]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSDelUser] 
END 
GO

CREATE PROC [dbo].[SYSDelUser] 
    @Id int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[User]	SET
		[Active] = 0,
		[ModificationDate] = GETDATE()
	WHERE  [Id] = @Id

	COMMIT
GO