/*-------------------------------------------------
---------Create By: Diego Gonzalez-----------------
---------Creation Date: 2017-07-05-----------------
---------Description: Update Cat Type User---------
*/-------------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSUpdCatTypeUser]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSUpdCatTypeUser] 
END 
GO

CREATE PROC [dbo].[SYSUpdCatTypeUser] 

    @Id  		INT,
    @TypeUser 	NVARCHAR(100)

AS 

	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[CatTypeUser] SET
		[TypeUser] = @TypeUser,
		[ModificationDate] = GETDATE()
	WHERE  [Id] = @Id

	COMMIT
GO