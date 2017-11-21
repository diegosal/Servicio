/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Get Visit----------------
*/----------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSGetVisit]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSGetVisit] 
END 
GO
CREATE PROC [dbo].[SYSGetVisit] 
   
   @Id INT

AS 

	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT
	
		V.[Id],
		T.[TypeVisit],
		CONCAT(	ISNULL(U.[UserName], '') , ' ', 
				ISNULL(U.[UserMiddleName], ''), ' ', 
				ISNULL(U.[UserLastName], ' '), ' ', 
				ISNULL(U.[UserMotherName], '')) Nombre,
		V.[CheckIn],
		V.[CheckOut],
		V.[VisitName],
		V.[Carnet],
		V.[Plates] 

	FROM   [dbo].[Visit] V
	LEFT JOIN [dbo].[User] U ON V.[UserId] = U.[Id]
	LEFT JOIN [dbo].[CatTypeVisit] T ON V.[VisitId] = T.[Id]
	WHERE  (V.[Id] = @Id OR @Id IS NULL) 

	COMMIT
GO
