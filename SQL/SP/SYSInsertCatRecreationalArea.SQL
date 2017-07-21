/*--------------------------------------------------
---------Create By: Diego Gonzalez------------------
---------Creation Date: 2017-07-05------------------
---------Description: Insert new Recreational Area--
*/--------------------------------------------------



USE [RM.DV.Core]
GO

DROP PROCEDURE IF EXISTS [dbo].[SYSInsertCatRecreationalArea]
GO

CREATE PROCEDURE [dbo].[SYSInsertCatRecreationalArea]

	@AreaName		NVARCHAR(255),
	@Active 		BIT

AS

	INSERT INTO [dbo].[CatrecReationalArea]
	(
		AreaName,
		CreationDate,
		ModificationDate,
		Active
	)
	VALUES
	(
		@AreaName,
		GETDATE(),
		GETDATE(),
		@Active
	)

GO

