/*--------------------------------------------------
---------Create By: Diego Gonzalez------------------
---------Creation Date: 2017-07-05------------------
---------Description: Insert Status-----------------
*/--------------------------------------------------



USE [RM.DV.Core]
GO

DROP PROCEDURE IF EXISTS [dbo].[SYSInsertCatStatus]
GO

CREATE PROCEDURE [dbo].[SYSInsertCatStatus]

	@StatusName		NVARCHAR(255),
	@Active			BIT

AS

	INSERT INTO [dbo].[CatStatus]
	(
		StatusName,
		CreationDate,
		ModificationDate,
		Active
	)
	VALUES
	(
		@StatusName,
		GETDATE(),
		GETDATE(),
		@Active
	)

GO

