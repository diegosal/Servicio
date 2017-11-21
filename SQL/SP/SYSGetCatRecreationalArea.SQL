/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Get Cat Recreational Area-
*/----------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSGetCatRecreationalArea]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSGetCatRecreationalArea] 
END 
GO

CREATE PROC [dbo].[SYSGetCatRecreationalArea] 

    @Id INT

AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT

		[Id],
		[AreaName],
		[CreationDate],
		[ModificationDate],
		[Active]

	FROM   [dbo].[CatRecreationalArea] 
	WHERE  ([Id] = @Id OR @Id IS NULL) 

	COMMIT
GO