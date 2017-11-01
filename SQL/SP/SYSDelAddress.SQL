/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Delete Address------------
*/----------------------------------------------

USE [RM.DV.Core]
GO

IF OBJECT_ID('[dbo].[SYSDelAddress]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSDelAddress] 
END 
GO

CREATE PROCEDURE [dbo].[SYSDelAddress]

	@Id		INT

AS

	SET NOCOUNT ON 
	SET XACT_ABORT ON

	BEGIN TRAN

	UPDATE [dbo].[Address] SET
		Active = 0,
        ModificationDate = GETDATE()
   	WHERE  [Id] = @Id

   	COMMIT

GO

