/*----------------------------------------------------
---------Create By: Diego Gonzalez--------------------
---------Creation Date: 2017-07-05--------------------
---------Description: Insert new Event----------------
*/----------------------------------------------------

USE [RM.DV.Core]
GO

IF OBJECT_ID('[dbo].[SYSInsEvent]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSInsEvent] 
END 
GO

CREATE PROCEDURE [dbo].[SYSInsEvent]

	@UserId 				INT,
	@RecreationalAreaId 	INT,
	@StartDate 				DATETIME,
	@EndDate 				DATETIME,
	@Status 				INT

AS
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	INSERT INTO [dbo].[Event]
	(
		[UserId],
		[RecreationalAreaId],
		[StartDate],
		[EndDate],
		[EventStatusId]
	)

	SELECT

		@UserId,
		@RecreationalAreaId,
		@StartDate,
		@EndDate,
		@Status

	COMMIT
GO

