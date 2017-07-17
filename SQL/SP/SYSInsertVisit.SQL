/*----------------------------------------------------
---------Create By: Diego Gonzalez--------------------
---------Creation Date: 2017-07-05--------------------
---------Description: Insert new Visit----------------
*/----------------------------------------------------



USE `RMDVCore`;

DROP PROCEDURE IF EXISTS `RMDVCore`.`SYSInsertVisite`;

DELIMITER $$

CREATE PROCEDURE `RMDVCore`.`SYSInsertVisit`

(
	IN VisitId 		INT(10) UNSIGNED,
	IN UserId		INT(10) UNSIGNED,
	IN VisitName	VARCHAR(150),
	IN Carnet		VARCHAR(250),
	IN Plates		VARCHAR(50)
)

BEGIN

	INSERT INTO `RMDVCore`.`Visit`
	(
		`VisitId`,
		`UserId`,
		`CheckIn`,
		`CheckOut`,
		`VisitName`,
		`Carnet`,
		`Plates`
	)
	VALUES
	(
		VisitId,
		UserId,
		NOW(),
		NOW(),
		VisitName,
		Carnet,
		Plates
	);

END

$$

DELIMITER ;