/*-------------------------------------------------
---------Create By: Diego Gonzalez-----------------
---------Creation Date: 2017-07-05-----------------
---------Description: Update Cat Recreational Area-
*/-------------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSUpdCatRecreationalArea]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSUpdCatRecreationalArea] 
END 
GO

CREATE PROC [dbo].[SYSUpdCatRecreationalArea] 
    
    @Id  		INT,
    @AreaName 	NVARCHAR(255)
    
AS 

	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[CatRecreationalArea] SET
		[AreaName] = @AreaName, 
		[ModificationDate] = GETDATE()
	WHERE  [Id] = @Id

	COMMIT
GO