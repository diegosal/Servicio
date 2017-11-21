/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Get Payment---------------
*/----------------------------------------------

USE [RM.DV.Core];
GO

IF OBJECT_ID('[dbo].[SYSGetPayment]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[SYSGetPayment] 
END 
GO

CREATE PROC [dbo].[SYSGetPayment] 
    
    @Id INT

AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT

		P.[Id],
		CONCAT(	ISNULL(U.[UserName], '') , ' ', 
				ISNULL(U.[UserMiddleName], ''), ' ', 
				ISNULL(U.[UserLastName], ' '), ' ', 
				ISNULL(U.[UserMotherName], '')) Nombre,
		S.[StatusName],
		P.[Amount], 
		P.[PaymentDate]

	FROM   [dbo].[Payment] P
	LEFT JOIN  [dbo].[User] U ON P.[UserId] = U.[Id]
	LEFT JOIN  [dbo].[CatPaymentStatus] S ON P.[PaymentStatusId] = S.[Id]
	WHERE  (P.[Id] = @Id OR @Id IS NULL) 

	COMMIT
GO