/*-------------------------------------------------
---------Create By: Diego Gonzalez-----------------
---------Creation Date: 2017-07-05-----------------
---------Description: Update User-----------------
*/-------------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSUpdUser]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSUpdUser] 
END 
GO

CREATE PROC [dbo].[SYSUpdUser] 

    @Id 				INT,
    @TypeId 			INT,
    @UserName 			NVARCHAR(150),
    @UserMiddleName 	NVARCHAR(150),
    @UserLastName 		NVARCHAR(150),
    @UserMotherName 	NVARCHAR(150),
    @Email 				NVARCHAR(255)

AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[User]	SET
		[TypeId] = @TypeId,
		[UserName] = @UserName,
		[UserMiddleName] = @UserMiddleName,
		[UserLastName] = @UserLastName,
		[UserMotherName] = @UserMotherName,
		[Email] = @Email,
		[ModificationDate] = GETDATE()
	WHERE  [Id] = @Id
	
	COMMIT
GO