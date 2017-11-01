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
    
    @Plates nvarchar(50)

AS

	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	DECLARE @VehicleId AS INT
	DECLARE @CheckIn AS DATETIME
	
	SELECT TOP 1 @VehicleId = [Id], @CheckIn = MAX([CreationDate])
	FROM [dbo].[Vehicle]
	WHERE [Plates] = @Plates 
	GROUP BY Id ORDER BY Id DESC

	BEGIN TRAN

	UPDATE [dbo].[Vehicle] SET 
	[ModificationDate] = GETDATE()
	WHERE  [Id] = @VehicleId

	COMMIT
GO