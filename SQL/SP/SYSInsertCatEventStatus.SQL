/*--------------------------------------------------
---------Create By: Diego Gonzalez------------------
---------Creation Date: 2017-07-05------------------
---------Description: Insert EventStatus------------
*/--------------------------------------------------



USE [RM.DV.Core]
GO

DROP PROCEDURE IF EXISTS [dbo].[SYSInsertCatEventStatus]
GO

CREATE PROCEDURE [dbo].[SYSInsertCatEventStatus]

	@StatusName		NVARCHAR(255),
	@Active			BIT

AS

	INSERT INTO [dbo].[CatEventStatus]
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

