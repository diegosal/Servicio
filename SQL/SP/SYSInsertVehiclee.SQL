/*----------------------------------------------------
---------Create By: Diego Gonzalez--------------------
---------Creation Date: 2017-07-05--------------------
---------Description: Insert new Vehicle--------------
*/----------------------------------------------------



USE `RMDVCore`;

DROP PROCEDURE IF EXISTS `RMDVCore`.`SYSInsertVehicle`;

DELIMITER $$

CREATE PROCEDURE `RMDVCore`.`SYSInsertVehiclee`

(
	IN UserId 	INT(10) UNSIGNED,
	IN Plates 	VARCHAR(50),
	IN Model	VARCHAR(255),
	IN Active	BIT	 
)

BEGIN

	INSERT INTO `RMDVCore`.`Vehicle`
	(
		`UserId`,
		`Plates`,
		`Model`,
		`CreationDate`,
		`ModificationDate`,
		`Active`
	)
	VALUES
	(
		UserId,
		Plates,
		Model,
		NOW(),
		NOW(),
		Active
	);

END

$$

DELIMITER ;