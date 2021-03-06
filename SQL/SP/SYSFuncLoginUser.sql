/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Login Funtion-------------
*/----------------------------------------------

USE [RM.DV.Core]
GO

IF OBJECT_ID('[dbo].[SYSFuncLoginUser]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSFuncLoginUser] 
END 
GO

CREATE PROCEDURE [dbo].[SYSFuncLoginUser]

	@Email		NVARCHAR(255)

AS

	SELECT
		Id,
		TypeId,
		UserName,
		UserMiddleName,
		UserLastName,
		UserMotherName,
		Email,
		PassWord,
		PassWordSalt,
		Active
	FROM [dbo].[User]
	WHERE Email = @Email AND Active = 1;

GO

