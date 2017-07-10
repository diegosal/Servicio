/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Insert new Eventuality----
*/----------------------------------------------



USE `RMDVCore`;

DROP PROCEDURE IF EXISTS `RMDVCore`.`SYSInsertCatEventuality`;

DELIMITER $$

CREATE PROCEDURE `RMDVCore`.`SYSInsertCatEventuality`

(
	IN EventualityName		VARCHAR(255),
	IN Active				BIT
)

BEGIN

	INSERT INTO `rmdvcore`.`cateventuality`
	(
		`EventualityName`,
		`CreationDate`,
		`ModificationDate`,
		`Active`
	)

	VALUES
	(
		EventualityName,
		NOW(),
		NOW(),
		Active
	);

END

$$

DELIMITER ;