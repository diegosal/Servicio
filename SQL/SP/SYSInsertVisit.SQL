/*----------------------------------------------------
---------Create By: Diego Gonzalez--------------------
---------Creation Date: 2017-07-05--------------------
---------Description: Insert new Visit----------------
*/----------------------------------------------------



USE [RM.DV.Core]
GO

DROP PROCEDURE IF EXISTS [dbo].[SYSInsertVisite]
GO

CREATE PROCEDURE [dbo].[SYSInsertVisit]

	@VisitId 	INT,
	@UserId		INT,
	@VisitName	NVARCHAR(150),
	@Carnet		NVARCHAR(250),
	@Plates		NVARCHAR(50)

AS

	INSERT INTO [dbo].[Visit]
	(
		VisitId,
		UserId,
		CheckIn,
		CheckOut,
		VisitName,
		Carnet,
		Plates
	)
	VALUES
	(
		@VisitId,
		@UserId,
		GETDATE(),
		GETDATE(),
		@VisitName,
		@Carnet,
		@Plates
	)

GO