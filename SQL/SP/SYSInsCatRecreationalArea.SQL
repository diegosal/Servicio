/*--------------------------------------------------
---------Create By: Diego Gonzalez------------------
---------Creation Date: 2017-07-05------------------
---------Description: Insert new Recreational Area--
*/--------------------------------------------------

USE [RM.DV.Core]
GO

IF OBJECT_ID('[dbo].[SYSInsCatRecreationalArea]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSInsCatRecreationalArea] 
END 
GO

CREATE PROCEDURE [dbo].[SYSInsCatRecreationalArea]

	@AreaName		NVARCHAR(255),
	@Active 		BIT

AS

	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	INSERT INTO [dbo].[CatrecReationalArea]
	(
		[AreaName],
		[CreationDate],
		[ModificationDate],
		[Active]
	)
	
	SELECT

		@AreaName,
		GETDATE(),
		GETDATE(),
		@Active
               
	COMMIT
GO