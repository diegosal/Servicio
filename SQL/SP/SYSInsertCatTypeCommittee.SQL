/*--------------------------------------------------
---------Create By: Diego Gonzalez------------------
---------Creation Date: 2017-07-05------------------
---------Description: Insert Type Committee---------
*/--------------------------------------------------



USE [RM.DV.Core]
GO

DROP PROCEDURE IF EXISTS [dbo].[SYSInsertCatTypeCommittee]
GO

CREATE PROCEDURE [dbo].[SYSInsertCatTypeCommittee]

	@TypeCommittee		NVARCHAR(255),
	@Active				BIT

AS

	INSERT INTO [dbo].[CatTypeCommittee]
	(
		TypeCommittee,
		CreationDate,
		ModificationDate,
		Active
    )

	VALUES
	(
		@TypeCommittee,
		GETDATE(),
		GETDATE(),
		@Active
	)

GO

