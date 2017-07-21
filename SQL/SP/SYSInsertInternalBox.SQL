/*----------------------------------------------------
---------Create By: Diego Gonzalez--------------------
---------Creation Date: 2017-07-05--------------------
---------Description: Insert new Internal Box---------
*/----------------------------------------------------



USE [RM.DV.Core]
GO

DROP PROCEDURE IF EXISTS [dbo].[SYSInsertInternalBox]
GO

CREATE PROCEDURE [dbo].[SYSInsertInternalBox]

	@Amount		NUMERIC(18,0)

AS

	INSERT INTO [dbo].[InternalBox]
	(
		Amount,
		CreationDate
    )
	VALUES
	(
		@Amount,
		GETDATE()
    )

GO

