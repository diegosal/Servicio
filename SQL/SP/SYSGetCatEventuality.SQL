/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Get Cat Eventuality-------
*/----------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSGetCatEventuality]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSGetCatEventuality] 
END 
GO

CREATE PROC [dbo].[SYSGetCatEventuality] 

    @Id INT

AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT

		[Id],
		[EventualityName],
		[CreationDate],
		[ModificationDate],
		[Active] 
		
	FROM   [dbo].[CatEventuality] 
	WHERE  ([Id] = @Id OR @Id IS NULL) 

	COMMIT
GO