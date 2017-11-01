/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Insert new Type User------
*/----------------------------------------------

USE [RM.DV.Core]
GO

IF OBJECT_ID('[dbo].[SYSInsCatTypeUser]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSInsCatTypeUser] 
END 
GO

CREATE PROCEDURE [dbo].[SYSInsCatTypeUser]

	@TypeUser				NVARCHAR(100),
	@Active					BIT

AS

	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	INSERT INTO [dbo].[CatTypeUser]
	(
		[TypeUser],
		[CreationDate],
		[ModificationDate],
		[Active]
	)

	SELECT

		@TypeUser,
		GETDATE(),
		GETDATE(),
		@Active

	COMMIT
GO