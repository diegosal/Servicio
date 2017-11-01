/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Get Cat Payment Status----
*/----------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSGetCatPaymentStatus]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSGetCatPaymentStatus] 
END 
GO

CREATE PROC [dbo].[SYSGetCatPaymentStatus] 
    
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

	FROM   [dbo].[CatPaymentStatus] 
	WHERE  ([Id] = @Id OR @Id IS NULL) 

	COMMIT
	
GO
