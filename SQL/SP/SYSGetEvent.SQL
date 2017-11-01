/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Get Event-----------------
*/----------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSGetEvent]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSGetEvent] 
END 
GO

CREATE PROC [dbo].[SYSGetEvent] 
    
    @Id INT

AS

	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT 
		
		E.[Id],
		CONCAT(	ISNULL(U.[UserName], '') , ' ', 
				ISNULL(U.[UserMiddleName], ''), ' ', 
				ISNULL(U.[UserLastName], ' '), ' ', 
				ISNULL(U.[UserMotherName], '')) Nombre, 
		S.[StatusName],
		R.[AreaName],
		E.[StartDate],
		E.[EndDate] 

	FROM   [dbo].[Event] E
	LEFT JOIN  [dbo].[User] U ON E.[UserId] = U.[Id]
	LEFT JOIN  [dbo].[CatEventStatus] S ON E.[EventStatusId] = S.[Id]
	LEFT JOIN  [dbo].[CatRecreationalArea] R ON E.[RecreationalAreaId] = R.[Id]
	WHERE  (E.[Id] = @Id OR @Id IS NULL) 

	COMMIT
GO