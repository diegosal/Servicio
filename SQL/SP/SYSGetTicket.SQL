/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Get Ticket----------------
*/----------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSGetTicket]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSGetTicket] 
END 
GO

CREATE PROC [dbo].[SYSGetTicket] 
    
    @Id INT

AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT 
		T.[Id],
		CONCAT(	ISNULL(U.[UserName], '') , ' ', 
				ISNULL(U.[UserMiddleName], ''), ' ', 
				ISNULL(U.[UserLastName], ' '), ' ', 
				ISNULL(U.[UserMotherName], '')) Nombre,
		E.[EventualityName],
		S.[StatusName],
		T.[CreationDate],
		T.[ModificationDate] 
		
	FROM   [dbo].[Ticket] T
	LEFT JOIN  [dbo].[User] U ON T.[UserId] = U.[Id]
	LEFT JOIN  [dbo].[CatEventuality] E ON T.[EventualityId] = E.[Id]
	LEFT JOIN  [dbo].[CatTicketStatus] S ON T.[StatusId] = S.[Id]
	WHERE  (T.[Id] = @Id OR @Id IS NULL) 

	COMMIT
GO