/*----------------------------------------------------
---------Create By: Diego Gonzalez--------------------
---------Creation Date: 2017-07-05--------------------
---------Description: Insert new Payment--------------
*/----------------------------------------------------

UNSIGNED

USE `RMDVCore`;

DROP PROCEDURE IF EXISTS `RMDVCore`.`SYSInsertPayment`;

DELIMITER $$

CREATE PROCEDURE `RMDVCore`.`SYSInsertPayment`

(
	IN UserId 			INT(10) UNSIGNED,
	IN Amount 			DECIMAL(18,0),
	IN PaymentStatus 	BIT 
)

BEGIN

	INSERT INTO `RMDVCore`.`Payment`
	(
		`UserId`,
		`Amount`,
		`PaymentStatus`,
		`PaymentDate`
	)
	VALUES
	(
		UserId,
		Amount,
		PaymentStatus,
		NOW()
	);

END

$$

DELIMITER ;