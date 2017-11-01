/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Insert new Ticket---------
*/----------------------------------------------

USE [RM.DV.Core]
GO

IF OBJECT_ID('[dbo].[SYSInsTicket]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSInsTicket] 
END 
GO

CREATE PROCEDURE [dbo].[SYSInsTicket]

	@UserId 			INT,
	@EventualityId	 	INT,
	@StatusId			INT

AS

	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	INSERT INTO [dbo].[Ticket]
	(
		[UserId],
		[EventualityId],
		[StatusId],
		[CreationDate],
		[ModificationDate]
	)

	SELECT

		@UserId,
		@EventualityId,
		@StatusId,
		GETDATE(),
		GETDATE()
	
	COMMIT
GO