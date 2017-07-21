/*--------------------------------------------------
---------Create By: Diego Gonzalez------------------
---------Creation Date: 2017-07-05------------------
---------Description: Insert TicketStatus-----------
*/--------------------------------------------------



USE [RM.DV.Core]
GO

DROP PROCEDURE IF EXISTS [dbo].[SYSInsertCatTicketStatus]
GO

CREATE PROCEDURE [dbo].[SYSInsertCatTicketStatus]

	@StatusName		NVARCHAR(255),
	@Active			BIT

AS

	INSERT INTO [dbo].[CatTicketStatus]
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

