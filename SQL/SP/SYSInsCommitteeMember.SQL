/*----------------------------------------------------
---------Create By: Diego Gonzalez--------------------
---------Creation Date: 2017-07-05--------------------
---------Description: Insert new Committee Member-----
*/----------------------------------------------------

USE [RM.DV.Core]
GO

IF OBJECT_ID('[dbo].[SYSInsCommitteeMember]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSInsCommitteeMember] 
END 
GO

CREATE PROCEDURE [dbo].[SYSInsCommitteeMember]

	@UserId 			 	INT,
	@CommitteeTypeId	 	INT,
	@Active					BIT

AS

	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	INSERT INTO [dbo].[CommitteeMember]
	(
		[UserId],
        [CommitteeTypeId],
		[CreationDate],
		[ModificationDate],
		[Active]
	)

	SELECT

		@UserId,
        @CommitteeTypeId,
		GETDATE(),
		GETDATE(),
		@Active

	COMMIT
GO