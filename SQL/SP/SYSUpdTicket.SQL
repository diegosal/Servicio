/*-------------------------------------------------
---------Create By: Diego Gonzalez-----------------
---------Creation Date: 2017-07-05-----------------
---------Description: Update Ticket---------------
*/-------------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSUpdTicket]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSUpdTicket] 
END 
GO

CREATE PROC [dbo].[SYSUpdTicket] 
    
    @Id 		INT,
    @StatusId 	INT

AS 

	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Ticket] SET 
		[StatusId] = @StatusId,
		[ModificationDate] = GETDATE()
	WHERE  [Id] = @Id

	COMMIT
GO