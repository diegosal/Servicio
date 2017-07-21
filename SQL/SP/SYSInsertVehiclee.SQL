/*----------------------------------------------------
---------Create By: Diego Gonzalez--------------------
---------Creation Date: 2017-07-05--------------------
---------Description: Insert new Vehicle--------------
*/----------------------------------------------------



USE [RM.DV.Core]
GO

DROP PROCEDURE IF EXISTS [dbo].[SYSInsertVehicle]
GO

CREATE PROCEDURE [dbo].[SYSInsertVehiclee]

	@UserId 	INT,
	@Plates 	NVARCHAR(50),
	@Model		NVARCHAR(255),
	@Active		BIT	 

AS

	INSERT INTO [dbo].[Vehicle]
	(
		UserId,
		Plates,
		Model,
		CreationDate,
		ModificationDate,
		Active
	)
	VALUES
	(
		@UserId,
		@Plates,
		@Model,
		GETDATE(),
		GETDATE(),
		@Active
	)

GO

