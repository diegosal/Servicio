/*--------------------------------------------------
---------Create By: Diego Gonzalez------------------
---------Creation Date: 2017-07-05------------------
---------Description: Delete Cat Event Status-------
*/--------------------------------------------------

USE [RM.DV.Core]
GO

IF OBJECT_ID('[dbo].[SYSDelCatEventStatus]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSDelCatEventStatus] 
END 
GO

CREATE PROCEDURE [dbo].[SYSDelCatEventStatus]

	@Id	INT

AS
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[CatEventStatus] SET
		Active = 0,
		ModificationDate = GETDATE()
	WHERE Id = @Id

	COMMIT
	
GO

