/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Get Cat Type User---------
*/----------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSGetCatTypeUser]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSGetCatTypeUser] 
END 
GO

CREATE PROC [dbo].[SYSGetCatTypeUser] 
    
    @Id INT

AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT

		[Id],
		[TypeUser],
		[CreationDate],
		[ModificationDate],
		[Active] 
		
	FROM   [dbo].[CatTypeUser] 
	WHERE  ([Id] = @Id OR @Id IS NULL) 

	COMMIT
GO