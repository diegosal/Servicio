/*--------------------------------------------------
---------Create By: Diego Gonzalez------------------
---------Creation Date: 2017-07-05------------------
---------Description: Insert EventStatus------------
*/--------------------------------------------------

USE [RM.DV.Core]
GO

IF OBJECT_ID('[dbo].[SYSInsCatEventStatus]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSInsCatEventStatus] 
END 
GO

CREATE PROCEDURE [dbo].[SYSInsCatEventStatus]

	@StatusName		NVARCHAR(255),
	@Active			BIT

AS
	
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	INSERT INTO [dbo].[CatEventStatus]
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

