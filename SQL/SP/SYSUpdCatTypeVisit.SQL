/*-------------------------------------------------
---------Create By: Diego Gonzalez-----------------
---------Creation Date: 2017-07-05-----------------
---------Description: Update Cat Type Visit--------
*/-------------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSUpdCatTypeVisit]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSUpdCatTypeVisit] 
END 
GO
CREATE PROC [dbo].[SYSUpdCatTypeVisit] 
    
    @Id  		INT,
    @TypeVisit 	NVARCHAR(255)

AS 

	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[CatTypeVisit]	SET
		[TypeVisit] = @TypeVisit,
		[ModificationDate] = GETDATE()
	WHERE  [Id] = @Id

	COMMIT
GO