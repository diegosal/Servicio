/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Get Internal Expense------
*/----------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSGetInternalExpense]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSGetInternalExpense] 
END 
GO

CREATE PROC [dbo].[SYSGetInternalExpense] 
    @Id int
AS

	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT
	
		[Id],
		[UserId],
		[Amount],
		[CreationDate] 

	FROM   [dbo].[InternalExpense] 
	WHERE  ([Id] = @Id OR @Id IS NULL) 

	COMMIT
GO