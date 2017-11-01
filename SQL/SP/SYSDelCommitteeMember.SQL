/*-------------------------------------------------
---------Create By: Diego Gonzalez-----------------
---------Creation Date: 2017-07-05-----------------
---------Description: Delete Cat Type Committee----
*/-------------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSDelCommitteeMember]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSDelCommitteeMember] 
END 
GO

CREATE PROC [dbo].[SYSDelCommitteeMember] 
    
    @Id INT

AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[CatTypeCommittee]	SET
		[Active] = 0,
		[ModificationDate] = GETDATE()
	WHERE  [Id] = @Id

	COMMIT
GO