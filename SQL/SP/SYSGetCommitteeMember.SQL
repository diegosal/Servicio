/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Get Committee Member------
*/----------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSGetCommitteeMember]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSGetCommitteeMember] 
END 
GO
CREATE PROC [dbo].[SYSGetCommitteeMember] 
    
    @Id INT

AS

	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT

		C.[Id],
		CONCAT(	ISNULL(U.[UserName], '') , ' ', 
				ISNULL(U.[UserMiddleName], ''), ' ', 
				ISNULL(U.[UserLastName], ' '), ' ', 
				ISNULL(U.[UserMotherName], '')) Nombre,
		T.[TypeCommittee],
		C.[CreationDate],
		C.[ModificationDate],
		C.[Active] 

	FROM   [dbo].[CommitteeMember] C
	LEFT JOIN  [dbo].[User] U ON C.[UserId] = U.[Id]
	LEFT JOIN [dbo].[CatTypeCommittee] T ON C.[CommitteeTypeId] = T.[id]
	WHERE  (C.[Id] = @Id OR @Id IS NULL) AND C.[Active] = 1

	COMMIT
GO