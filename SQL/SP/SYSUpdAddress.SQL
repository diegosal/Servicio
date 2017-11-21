/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Update Address------------
*/----------------------------------------------

USE [RM.DV.Core]
GO

IF OBJECT_ID('[dbo].[SYSUpdAddress]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSUpdAddress] 
END 
GO

CREATE PROCEDURE [dbo].[SYSUpdAddress]

	@Id 				INT,
	@StreetName 		NVARCHAR(255),
	@Number 			NVARCHAR(10),
	@PostalCode 		NVARCHAR(10)

AS

	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Address] SET
		[StreetName] = @StreetName,
		[Number] = @Number,
		[PostalCode] = @PostalCode,
		[ModificationDate] = GETDATE()
	WHERE  [Id] = @Id
	
	COMMIT

GO

