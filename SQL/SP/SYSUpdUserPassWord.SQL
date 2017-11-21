/*-------------------------------------------------
---------Create By: Diego Gonzalez-----------------
---------Creation Date: 2017-07-05-----------------
---------Description: Update User Password---------
*/-------------------------------------------------

USE [RM.DV.Core]
GO

IF OBJECT_ID('[dbo].[SYSUpdUserPassWord]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSUpdUserPassWord] 
END 
GO

CREATE PROC [dbo].[SYSUpdUserPassWord] 

    @Id 				INT,
    @PassWord         	NVARCHAR(MAX),
	@PassWordSalt	  	NVARCHAR(32)

AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[User]	SET
		[PassWord] = @PassWord,
		[PassWordSalt] = @PassWordSalt,
		[ModificationDate] = GETDATE()
	WHERE  [Id] = @Id
	
	COMMIT
GO