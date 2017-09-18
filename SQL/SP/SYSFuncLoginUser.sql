/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Login Funtion-------------
*/----------------------------------------------


USE [RM.DV.Core]
GO

DROP PROCEDURE IF EXISTS [dbo].[SYSFuncLoginUser]
GO

CREATE PROCEDURE [dbo].[SYSFuncLoginUser]

	@Email		NVARCHAR(255)

AS

	SELECT
		Id,
		TypeId,
		CONCAT(UserName, ' ', UserMiddleName, ' ', UserLastName, ' ',UserMotherName) Nombre,
		Email,
		PassWord,
		PassWordSalt,
		Active
	FROM [dbo].[User]
	WHERE Email = @Email;

GO

