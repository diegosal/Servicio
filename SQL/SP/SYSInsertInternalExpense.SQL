/*----------------------------------------------------
---------Create By: Diego Gonzalez--------------------
---------Creation Date: 2017-07-05--------------------
---------Description: Insert new Internal Expense-----
*/----------------------------------------------------



USE `RMDVCore`;

DROP PROCEDURE IF EXISTS `RMDVCore`.`SYSInsertInternalExpense`;

DELIMITER $$

CREATE PROCEDURE `RMDVCore`.`SYSInsertInternalExpense`

(
	IN UserId 			INT(10) UNSIGNED,
	IN Amount 			DECIMAL(18,0)
)

BEGIN

	INSERT INTO `RMDVCore`.`InternalExpense`
	(
		`UserId`,
		`Amount`,
		`CreationDate`
	)
	VALUES
	(
		UserId,
		Amount,
		NOW()
	);

END

$$

DELIMITER ;