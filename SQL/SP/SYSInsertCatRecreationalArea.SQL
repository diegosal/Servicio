/*--------------------------------------------------
---------Create By: Diego Gonzalez------------------
---------Creation Date: 2017-07-05------------------
---------Description: Insert new Recreational Area--
*/--------------------------------------------------



USE `RMDVCore`;

DROP PROCEDURE IF EXISTS `RMDVCore`.`SYSInsertCatRecreationalArea`;

DELIMITER $$

CREATE PROCEDURE `RMDVCore`.`SYSInsertCatRecreationalArea`

(
	IN AreaName		VARCHAR(255),
	IN Active 		BIT
)

BEGIN

	INSERT INTO `rmdvcore`.`catrecreationalarea`
	(
		`AreaName`,
		`CreationDate`,
		`ModificationDate`,
		`Active`
	)
	VALUES
	(
		AreaName,
		NOW(),
		NOW(),
		Active
	);

END

$$

DELIMITER ;