/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Get Internal Box----------
*/----------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSGetInternalBox]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSGetInternalBox] 
END 
GO

CREATE PROC [dbo].[SYSGetInternalBox] 
    
    @Amount 		NUMERIC(18, 0),
    @CreationDate 	DATETIME

AS

	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT 
		[Amount],
		[CreationDate] 
	FROM   [dbo].[InternalBox] 
	WHERE  ([Amount] = @Amount OR @Amount IS NULL) 
	       AND ([CreationDate] = @CreationDate OR @CreationDate IS NULL) 

	COMMIT
GO