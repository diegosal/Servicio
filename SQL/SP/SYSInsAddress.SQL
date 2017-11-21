/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Insert new Address--------
*/----------------------------------------------

USE [RM.DV.Core]
GO

IF OBJECT_ID('[dbo].[SYSInsAddress]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSInsAddress] 
END 
GO

CREATE PROCEDURE [dbo].[SYSInsAddress]

	@UserId  		INT,
    @StreetName 	NVARCHAR(255),
    @Number 		NVARCHAR(10),
    @PostalCode 	NVARCHAR(10),
    @Active 		BIT

AS
	
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Address] 
	(
		[UserId],
		[StreetName],
		[Number],
		[PostalCode],
		[CreationDate],
		[ModificationDate],
		[Active]
	)
	
	SELECT 
		@UserId,
		@StreetName,
		@Number,
		@PostalCode,
		GETDATE(),
		GETDATE(),
		@Active
        
	COMMIT

GO

