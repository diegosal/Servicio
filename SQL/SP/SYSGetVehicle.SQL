/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Get Vehicle---------------
*/----------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSGetVehicle]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSGetVehicle] 
END 
GO

CREATE PROC [dbo].[SYSGetVehicle] 
    
    @Id INT,
    @Active BIT

AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT

		V.[Id],
		CONCAT(	ISNULL(U.[UserName], '') , ' ', 
				ISNULL(U.[UserMiddleName], ''), ' ', 
				ISNULL(U.[UserLastName], ' '), ' ', 
				ISNULL(U.[UserMotherName], '')) Nombre,
		V.[Plates],
		V.[Model],
		V.[CreationDate],
		V.[ModificationDate],
		V.[Active] 

	FROM   [dbo].[Vehicle] V
	LEFT JOIN  [dbo].[User] U ON V.[UserId] = U.[Id]
	WHERE  (V.[Id] = @Id OR @Id IS NULL) AND
	(V.[Active] = @Active OR @Active IS NULL) 

	COMMIT
GO