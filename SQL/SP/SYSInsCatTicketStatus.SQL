/*--------------------------------------------------
---------Create By: Diego Gonzalez------------------
---------Creation Date: 2017-07-05------------------
---------Description: Insert Cat Ticket Status------
*/--------------------------------------------------

USE [RM.DV.Core]
GO

IF OBJECT_ID('[dbo].[SYSInsCatTicketStatus]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSInsCatTicketStatus] 
END 
GO

CREATE PROCEDURE [dbo].[SYSInsCatTicketStatus]

	@StatusName		NVARCHAR(255),
	@Active			BIT

AS
	
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	INSERT INTO [dbo].[CatTicketStatus]
	(
		[StatusName],
		[CreationDate],
		[ModificationDate],
		[Active]
	)
	
	SELECT

		@StatusName,
		GETDATE(),
		GETDATE(),
		@Active

	COMMIT
GO