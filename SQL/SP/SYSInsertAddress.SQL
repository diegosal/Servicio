/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Insert new Address--------
*/----------------------------------------------



USE [RM.DV.Core]
GO

DROP PROCEDURE IF EXISTS [dbo].[SYSInsertAddress]
GO

CREATE PROCEDURE [dbo].[SYSInsertAddress]

	@UserId 			INT,
	@StreetName 		NVARCHAR(255),
	@Number 			NVARCHAR(10),
	@PostalCode 		NVARCHAR(10),
	@Active 			BIT

AS

	INSERT INTO [dbo].[Address]
	(
		 UserId
        ,StreetName
        ,Number
        ,PostalCode
        ,CreationDate
        ,ModificationDate
        ,Active
    )
    
	VALUES
	(
		@UserId,
		@StreetName,
		@Number,
		@PostalCode,
		GETDATE(),
		GETDATE(),
		@Active
    )

GO

