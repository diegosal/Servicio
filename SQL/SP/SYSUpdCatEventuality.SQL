/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Update Cat Eventuality----
*/----------------------------------------------

USE [RM.DV.Core]
GO

IF OBJECT_ID('[dbo].[SYSUpdCatEventuality]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSUpdCatEventuality] 
END 
GO

CREATE PROC [dbo].[SYSUpdCatEventuality] 

	@Id						INT,
	@EventualityName		NVARCHAR(255)

AS
	
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[CatEventuality] SET
		[EventualityName] = @EventualityName,
		[ModificationDate] = GETDATE()
	WHERE Id = @Id

	COMMIT

GO

