/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Get Cat Event Status------
*/----------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSGetCatEventStatus]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSGetCatEventStatus] 
END 
GO

CREATE PROC [dbo].[SYSGetCatEventStatus] 
   
    @Id INT
    
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT 

		[Id],
	   	[StatusName],
	   	[CreationDate],
	   	[ModificationDate],
	   	[Active] 

	FROM   [dbo].[CatEventStatus] 
	WHERE  ([Id] = @Id OR @Id IS NULL) 

	COMMIT
GO