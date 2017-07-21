/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Insert new Type Visit-----
*/----------------------------------------------



USE [RM.DV.Core]
GO

DROP PROCEDURE IF EXISTS [dbo].[SYSInsertCatTypeVisit]
GO

CREATE PROCEDURE [dbo].[SYSInsertCatTypeVisit]

	@TypeVisit			NVARCHAR(255),
	@Active				BIT

AS

	INSERT INTO [dbo].[CatTypeVisit]
	(
		TypeVisit,
		CreationDate,
		ModificationDate,
		Active
	)

	VALUES
	(
		@TypeVisit,
		GETDATE(),
		GETDATE(),
		@Active
	)

GO

