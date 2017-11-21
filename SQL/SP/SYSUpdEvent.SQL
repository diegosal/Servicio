/*-------------------------------------------------
---------Create By: Diego Gonzalez-----------------
---------Creation Date: 2017-07-05-----------------
---------Description: Update Event-----------------
*/-------------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSUpdEvent]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSUpdEvent] 
END 
GO

CREATE PROC [dbo].[SYSUpdEvent] 
    
    @Id  				INT,
    @EventStatus 		INT,
    @RecreationalAreaId INT,
    @StartDate 			DATETIME,
    @EndDate 			DATETIME

AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Event] SET
		[EventStatusId] = @EventStatus,
		[RecreationalAreaId] = @RecreationalAreaId,
		[StartDate] = @StartDate, 
		[EndDate] = @EndDate
	WHERE  [Id] = @Id

	COMMIT
GO