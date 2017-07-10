/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Insert new Assist Control-
*/----------------------------------------------



USE `RMDVCore`;

DROP PROCEDURE IF EXISTS `RMDVCore`.`SYSInsertAssistControl`;

DELIMITER $$

CREATE PROCEDURE `RMDVCore`.`SYSInsertAssistControl`

(
	IN UserId	 INT(10)
)

BEGIN

	INSERT INTO `rmdvcore`.`assistcontrol`
	(
		`UserId`,
		`CheckIn`,
		`CheckOut`
	)

	VALUES
	(
		UserId,
		NOW(),
		NOW()
	);

END

$$

DELIMITER ;