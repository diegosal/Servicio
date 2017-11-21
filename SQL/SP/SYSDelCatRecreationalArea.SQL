/*-------------------------------------------------
---------Create By: Diego Gonzalez-----------------
---------Creation Date: 2017-07-05-----------------
---------Description: Delete Cat Recreational Area-
*/-------------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSDelCatRecreationalArea]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSDelCatRecreationalArea] 
END 
GO

CREATE PROC [dbo].[SYSDelCatRecreationalArea] 
    
    @Id  		INT,
    @AreaName 	NVARCHAR(255),
    @Active 	BIT
    
AS 

	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[CatRecreationalArea] SET
		[Active] = 0, 
		[ModificationDate] = GETDATE()
	WHERE  [Id] = @Id

	COMMIT
GO