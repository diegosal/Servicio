/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Update Vehicle------------
*/----------------------------------------------

USE [RM.DV.Core]
GO

IF OBJECT_ID('[dbo].[SYSUpdVisit]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSUpdVisit] 
END 
GO
CREATE PROC [dbo].[SYSUpdVisit] 

    @Carnet NVARCHAR(250)

AS

	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	DECLARE @VisitId AS INT
	DECLARE @CheckIn AS DATETIME
	
	SELECT TOP 1 @VisitId = [Id], @CheckIn = MAX([CheckIn])
	FROM [dbo].[Visit]
	WHERE [Carnet] = @Carnet 
	GROUP BY Id ORDER BY Id DESC

	BEGIN TRAN

	UPDATE [dbo].[Visit] SET
		[CheckOut] = GETDATE()
	WHERE  [Id] = @VisitId

	COMMIT
GO