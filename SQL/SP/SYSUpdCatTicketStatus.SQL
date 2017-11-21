/*-------------------------------------------------
---------Create By: Diego Gonzalez-----------------
---------Creation Date: 2017-07-05-----------------
---------Description: Update Cat Ticket Status-----
*/-------------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSUpdCatTicketStatus]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSUpdCatTicketStatus] 
END 
GO

CREATE PROC [dbo].[SYSUpdCatTicketStatus] 
    
    @Id  			INT,
    @StatusName 	NVARCHAR(255)

AS 

	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[CatTicketStatus] SET
		[StatusName] = @StatusName,
		[ModificationDate] = GETDATE()
	WHERE  [Id] = @Id
	
	COMMIT
GO