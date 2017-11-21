/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Update Vehicle------------
*/----------------------------------------------

USE [RM.DV.Core]
GO

IF OBJECT_ID('[dbo].[SYSUpdVehicle]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSUpdVehicle] 
END 
GO

CREATE PROC [dbo].[SYSUpdVehicle] 
    
    @Id		INT,
	@Plates NVARCHAR(50)

AS

	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	UPDATE [dbo].[Vehicle] SET 
	[Plates] = @Plates,
	[ModificationDate] = GETDATE()
	WHERE  [Id] = @Id

	COMMIT
GO