/*----------------------------------------------------
---------Create By: Diego Gonzalez--------------------
---------Creation Date: 2017-07-05--------------------
---------Description: Insert new Internal Box---------
*/----------------------------------------------------



USE `RMDVCore`;

DROP PROCEDURE IF EXISTS `RMDVCore`.`SYSInsertInternalBox`;

DELIMITER $$

CREATE PROCEDURE `RMDVCore`.`SYSInsertInternalBox`

(
	IN Amount 				DECIMAL(18,0)
)

BEGIN

	INSERT INTO `RMDVCore`.`InternalBox`
	(
		`Amount`,
		`CreationDate`
    )
	VALUES
	(
		Amount,
		NOW()
    );

END

$$

DELIMITER ;