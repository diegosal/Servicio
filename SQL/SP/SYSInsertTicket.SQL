/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Insert new Ticket---------
*/----------------------------------------------



USE [RM.DV.Core]
GO

DROP PROCEDURE IF EXISTS [dbo].[SYSInsertTicket]
GO

CREATE PROCEDURE [dbo].[SYSInsertTicket]

	@UserId 			INT,
	@EventualityId	 	INT,
	@StatusId			INT

AS

	INSERT INTO [dbo].[Ticket]
	(
		UserId,
		EventualityId,
		StatusId,
		CreationDate,
		ModificationDate
	)

	VALUES
	(
		@UserId,
		@EventualityId,
		@StatusId,
		GETDATE(),
		GETDATE()
	)
	
GO

