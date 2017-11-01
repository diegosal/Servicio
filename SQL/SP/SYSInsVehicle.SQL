/*----------------------------------------------------
---------Create By: Diego Gonzalez--------------------
---------Creation Date: 2017-07-05--------------------
---------Description: Insert new Vehicle--------------
*/----------------------------------------------------

USE [RM.DV.Core]
GO

IF OBJECT_ID('[dbo].[SYSInsVehicle]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSInsVehicle] 
END 
GO

CREATE PROCEDURE [dbo].[SYSInsVehicle]

	@UserId 	INT,
	@Plates 	NVARCHAR(50),
	@Model		NVARCHAR(255),
	@Active		BIT	 

AS 

	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	INSERT INTO [dbo].[Vehicle]
	(
		[UserId],
		[Plates],
		[Model],
		[CreationDate],
		[ModificationDate],
		[Active]
	)

	SELECT

		@UserId,
		@Plates,
		@Model,
		GETDATE(),
		GETDATE(),
		@Active
	
	COMMIT
GO

