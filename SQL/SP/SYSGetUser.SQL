/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Get User------------------
*/----------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSGetUser]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSGetUser] 
END 
GO

CREATE PROC [dbo].[SYSGetUser] 
    
    @Id 	INT,
    @Active BIT
AS 

	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT 

		U.[Id],
		C.[CompanyName],
		T.[TypeUser],
		U.[UserName],
		U.[UserMiddleName],
		U.[UserLastName],
		U.[UserMotherName],
		U.[Email],
		U.[PassWord],
		U.[PassWordSalt],
		U.[CreationDate],
		U.[ModificationDate],
		U.[Active]

	FROM   [dbo].[User] U
	LEFT JOIN [dbo].[Company] C ON U.[CompanyId] = C.[Id]
	LEFT JOIN [dbo].[CatTypeUser] T ON U.[TypeId] = T.[Id]
	WHERE (U.[Id] = @Id OR @Id IS NULL) AND
	(U.[Active] = @Active OR @Active IS NULL) 

	COMMIT
GO