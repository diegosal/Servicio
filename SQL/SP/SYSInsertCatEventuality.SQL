/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Insert new Eventuality----
*/----------------------------------------------



USE [RM.DV.Core]
GO

DROP PROCEDURE IF EXISTS [dbo].[SYSInsertCatEventuality]
GO

CREATE PROCEDURE [dbo].[SYSInsertCatEventuality]

	@EventualityName		NVARCHAR(255),
	@Active					BIT

AS

	INSERT INTO [dbo].[CatEventuality]
	(
		EventualityName,
		CreationDate,
		ModificationDate,
		Active
	)

	VALUES
	(
		@EventualityName,
		GETDATE(),
		GETDATE(),
		@Active
	)

GO

