/*----------------------------------------------------
---------Create By: Diego Gonzalez--------------------
---------Creation Date: 2017-07-05--------------------
---------Description: Insert new Committee Member-----
*/----------------------------------------------------



USE [RM.DV.Core]
GO

DROP PROCEDURE IF EXISTS [dbo].[SYSInsertCommitteeMember]
GO

CREATE PROCEDURE [dbo].[SYSInsertCommitteeMember]

	@UserId 			 	INT,
	@CommitteeTypeId	 	INT,
	@Active					BIT

AS

	INSERT INTO [dbo].[CommitteeMember]
	(
		UserId,
        CommitteeTypeId,
		CreationDate,
		ModificationDate,
		Active
	)

	VALUES
	(
		@UserId,
        @CommitteeTypeId,
		GETDATE(),
		GETDATE(),
		@Active
	)

GO

