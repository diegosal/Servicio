/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Get Cat Type Committee----
*/----------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSGetCatTypeCommittee]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSGetCatTypeCommittee] 
END 
GO

CREATE PROC [dbo].[SYSGetCatTypeCommittee] 
    
    @Id INT
    
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT

		[Id],
		[TypeCommittee],
		[CreationDate],
		[ModificationDate],
		[Active]

	FROM   [dbo].[CatTypeCommittee] 
	WHERE  ([Id] = @Id OR @Id IS NULL) 

	COMMIT
GO