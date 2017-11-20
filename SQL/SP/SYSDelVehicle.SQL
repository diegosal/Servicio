/*-------------------------------------------------
---------Create By: Diego Gonzalez-----------------
---------Creation Date: 2017-07-05-----------------
---------Description: Delete Vehicle---------------
*/-------------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSDelVehicle]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSDelVehicle] 
END 
GO

CREATE PROC [dbo].[SYSDelVehicle] 
    
    @Id			INT
AS 

	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Vehicle]	SET
		[Active] = 0,
		[ModificationDate] = GETDATE()
	WHERE  [Id] = @Id

	COMMIT
GO