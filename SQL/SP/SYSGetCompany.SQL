/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Get Company---------------
*/----------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSGetCompany]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSGetCompany] 
END 
GO

CREATE PROC [dbo].[SYSGetCompany] 
    
    @Id INT

AS

	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT
	
		[Id],
		[CompanyName],
		[CreationDate],
		[ModificationDate],
		[Active]

	FROM   [dbo].[Company] 
	WHERE  ([Id] = @Id OR @Id IS NULL) 

	COMMIT
GO