/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Insert new Type User------
*/----------------------------------------------



USE [RM.DV.Core]
GO

DROP PROCEDURE IF EXISTS [dbo].[SYSInsertCatTypeUser]
GO

CREATE PROCEDURE [dbo].[SYSInsertCatTypeUser]

	@TypeUser				NVARCHAR(100),
	@Active					BIT

AS

	INSERT INTO [dbo].[CatTypeUser]
	(
		TypeUser,
		CreationDate,
		ModificationDate,
		Active
	)

	VALUES
	(
		@TypeUser,
		GETDATE(),
		GETDATE(),
		@Active
	)

GO

