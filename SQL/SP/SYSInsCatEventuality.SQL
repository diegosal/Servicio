/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Insert new Eventuality----
*/----------------------------------------------

USE [RM.DV.Core]
GO

IF OBJECT_ID('[dbo].[SYSInsCatEventuality]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSInsCatEventuality] 
END 
GO

CREATE PROCEDURE [dbo].[SYSInsCatEventuality]

	@EventualityName		NVARCHAR(255),
	@Active					BIT

AS
	
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	INSERT INTO [dbo].[CatEventuality]
	(
		[EventualityName],
		[CreationDate],
		[ModificationDate],
		[Active]
	)

	SELECT
	
		@EventualityName,
		GETDATE(),
		GETDATE(),
		@Active

	COMMIT

GO

