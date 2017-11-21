/*-------------------------------------------------
---------Create By: Diego Gonzalez-----------------
---------Creation Date: 2017-07-05-----------------
---------Description: Delete Cat Ticket Status-----
*/-------------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSDelCatTicketStatus]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSDelCatTicketStatus] 
END 
GO

CREATE PROC [dbo].[SYSDelCatTicketStatus] 
   
    @Id INT
    
AS 

	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[CatTicketStatus] SET
		[Active] = 0,
		[ModificationDate] = GETDATE()
	WHERE  [Id] = @Id
	
	COMMIT

GO