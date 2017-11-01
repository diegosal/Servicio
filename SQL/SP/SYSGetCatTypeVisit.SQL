/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Get Cat Type Visit--------
*/----------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSGetCatTypeVisit]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSGetCatTypeVisit] 
END 
GO

CREATE PROC [dbo].[SYSGetCatTypeVisit] 
    
    @Id INT
    
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT

		[Id],
		[TypeVisit],
		[CreationDate],
		[ModificationDate],
		[Active]

	FROM   [dbo].[CatTypeVisit] 
	WHERE  ([Id] = @Id OR @Id IS NULL) 

	COMMIT
GO