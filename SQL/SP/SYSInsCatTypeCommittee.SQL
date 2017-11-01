/*--------------------------------------------------
---------Create By: Diego Gonzalez------------------
---------Creation Date: 2017-07-05------------------
---------Description: Insert Type Committee---------
*/--------------------------------------------------

USE [RM.DV.Core]
GO

IF OBJECT_ID('[dbo].[SYSInsCatTypeCommittee]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSInsCatTypeCommittee] 
END 
GO

CREATE PROCEDURE [dbo].[SYSInsCatTypeCommittee]

	@TypeCommittee		NVARCHAR(255),
	@Active				BIT

AS
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[CatTypeCommittee]
	(
		[TypeCommittee],
		[CreationDate],
		[ModificationDate],
		[Active]
    )

	SELECT

		@TypeCommittee,
		GETDATE(),
		GETDATE(),
		@Active

	COMMIT
GO

