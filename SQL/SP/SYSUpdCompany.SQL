/*-------------------------------------------------
---------Create By: Diego Gonzalez-----------------
---------Creation Date: 2017-07-05-----------------
---------Description: Update Company---------------
*/-------------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSUpdCompany]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSUpdCompany] 
END 
GO
CREATE PROC [dbo].[SYSUpdCompany] 
    
    @Id  			INT,
    @CompanyName 	NVARCHAR(255)

AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Company] SET
		[CompanyName] = @CompanyName,
		[ModificationDate] = GETDATE()
	WHERE  [Id] = @Id

	COMMIT
GO