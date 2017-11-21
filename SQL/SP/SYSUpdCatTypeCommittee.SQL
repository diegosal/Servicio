/*-------------------------------------------------
---------Create By: Diego Gonzalez-----------------
---------Creation Date: 2017-07-05-----------------
---------Description: Update Cat Type Committee----
*/-------------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSUpdCatTypeCommittee]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSUpdCatTypeCommittee] 
END 
GO

CREATE PROC [dbo].[SYSUpdCatTypeCommittee] 

    @Id  			INT,
    @TypeCommittee 	NVARCHAR(100)

AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[CatTypeCommittee]	SET
		[TypeCommittee] = @TypeCommittee,
		[ModificationDate] = GETDATE()
	WHERE  [Id] = @Id

	COMMIT
GO