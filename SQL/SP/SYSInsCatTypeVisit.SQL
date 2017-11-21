/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Insert new Type Visit-----
*/----------------------------------------------

USE [RM.DV.Core]
GO

IF OBJECT_ID('[dbo].[SYSInsCatTypeVisit]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSInsCatTypeVisit] 
END 
GO

CREATE PROCEDURE [dbo].[SYSInsCatTypeVisit]

	@TypeVisit			NVARCHAR(255),
	@Active				BIT

AS
	
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[CatTypeVisit]
	(
		[TypeVisit],
		[CreationDate],
		[ModificationDate],
		[Active]
	)

	SELECT

		@TypeVisit,
		GETDATE(),
		GETDATE(),
		@Active

	COMMIT
GO

