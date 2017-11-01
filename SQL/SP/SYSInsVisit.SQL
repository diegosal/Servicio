/*----------------------------------------------------
---------Create By: Diego Gonzalez--------------------
---------Creation Date: 2017-07-05--------------------
---------Description: Insert new Visit----------------
*/----------------------------------------------------

USE [RM.DV.Core]
GO

IF OBJECT_ID('[dbo].[SYSInsVisit]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSInsVisit] 
END 
GO

CREATE PROCEDURE [dbo].[SYSInsVisit]

	@VisitId 	INT,
	@UserId		INT,
	@VisitName	NVARCHAR(150),
	@Carnet		NVARCHAR(250),
	@Plates		NVARCHAR(50)

AS 

	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	INSERT INTO [dbo].[Visit]
	(
		[VisitId],
		[UserId],
		[CheckIn],
		[CheckOut],
		[VisitName],
		[Carnet],
		[Plates]
	)

	SELECT

		@VisitId,
		@UserId,
		GETDATE(),
		GETDATE(),
		@VisitName,
		@Carnet,
		@Plates

	COMMIT
GO