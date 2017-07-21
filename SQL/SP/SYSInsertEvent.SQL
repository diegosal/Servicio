/*----------------------------------------------------
---------Create By: Diego Gonzalez--------------------
---------Creation Date: 2017-07-05--------------------
---------Description: Insert new Event----------------
*/----------------------------------------------------



USE [RM.DV.Core]
GO

DROP PROCEDURE IF EXISTS [dbo].[SYSInsertEvent]
GO

CREATE PROCEDURE [dbo].[SYSInsertEvent]

	@UserId 				INT,
	@RecreationalAreaId 	INT,
	@StartDate 				DATETIME,
	@EndDate 				DATETIME,
	@Status 				BIT

AS

	INSERT INTO [dbo].[Event]
	(
		UserId,
		RecreationalAreaId,
		StartDate,
		EndDate,
		Status
	)
	VALUES
	(
		@UserId,
		@RecreationalAreaId,
		@StartDate,
		@EndDate,
		@Status
    )

GO

