/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Update Cat Event Status---
*/----------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSUpdCatEventStatus]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSUpdCatEventStatus] 
END 
GO

CREATE PROC [dbo].[SYSUpdCatEventStatus] 
    
    @Id  				INT,
    @StatusName 		NVARCHAR(255)

AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[CatEventStatus] SET
		[StatusName] = @StatusName,
		[ModificationDate] = GETDATE()
	WHERE  [Id] = @Id
	
	COMMIT
GO