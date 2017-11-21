/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Get Address---------------
*/----------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSGetAddress]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSGetAddress] 
END 
GO

CREATE PROC [dbo].[SYSGetAddress] 
	@Id INT
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT 
		
		[Id],
		[UserId],
		[StreetName],
		[Number],
		[PostalCode],
		[CreationDate],
		[ModificationDate],
		[Active]

	FROM [dbo].[Address]
	WHERE  ([Id] = @Id OR @Id IS NULL) AND [Active] = 1

	COMMIT
GO