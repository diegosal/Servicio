/*-------------------------------------------------
---------Create By: Diego Gonzalez-----------------
---------Creation Date: 2017-07-05-----------------
---------Description: Update Committee Member------
*/-------------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSUpdCommitteeMember]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSUpdCommitteeMember] 
END 
GO
CREATE PROC [dbo].[SYSUpdCommitteeMember] 
    
    @Id  				INT,
    @CommitteeTypeId 	INT

AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[CommitteeMember] SET
		[CommitteeTypeId] = @CommitteeTypeId,
		[ModificationDate] = GETDATE()
	WHERE  [Id] = @Id

	COMMIT
GO