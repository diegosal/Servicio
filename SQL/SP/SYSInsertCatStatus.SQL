/*--------------------------------------------------
---------Create By: Diego Gonzalez------------------
---------Creation Date: 2017-07-05------------------
---------Description: Insert Status-----------------
*/--------------------------------------------------



USE `RMDVCore`;

DROP PROCEDURE IF EXISTS `RMDVCore`.`SYSInsertCatStatus`;

DELIMITER $$

CREATE PROCEDURE `RMDVCore`.`SYSInsertCatStatus`

(
	IN StatusName		VARCHAR(255),
	IN Active			BIT
)

BEGIN

	INSERT INTO `rmdvcore`.`catstatus`
	(
		`StatusName`,
		`CreationDate`,
		`ModificationDate`,
		`Active`
	)
	VALUES
	(
		StatusName,
		NOW(),
		NOW(),
		Active
	);

END

$$

DELIMITER ;