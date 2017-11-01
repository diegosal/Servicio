/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Get Cat Ticket Status-----
*/----------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSGetCatTicketStatus]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSGetCatTicketStatus] 
END 
GO

CREATE PROC [dbo].[SYSGetCatTicketStatus] 
    
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

	FROM   [dbo].[CatTicketStatus] 
	WHERE  ([Id] = @Id OR @Id IS NULL) 

	COMMIT
GO