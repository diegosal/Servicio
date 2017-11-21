/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Delete Cat Eventuality----
*/----------------------------------------------

USE [RM.DV.Core]
GO

IF OBJECT_ID('[dbo].[SYSDelCatEventuality]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSDelCatEventuality] 
END 
GO

CREATE PROCEDURE [dbo].[SYSDelCatEventuality]

	@Id		INT

AS
	
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[CatEventuality] SET
		Active = 0,
		ModificationDate = GETDATE()
	WHERE Id = @Id

	COMMIT
	
GO

