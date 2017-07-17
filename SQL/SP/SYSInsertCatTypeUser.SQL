/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Insert new Type User------
*/----------------------------------------------



USE `RMDVCore`;

DROP PROCEDURE IF EXISTS `RMDVCore`.`SYSInsertCatTypeUser`;

DELIMITER $$

CREATE PROCEDURE `RMDVCore`.`SYSInsertCatTypeUser`

(
	IN TypeUser				VARCHAR(100),
	IN Active				BIT
)

BEGIN

	INSERT INTO `RMDVCore`.`CatTypeUser`
	(
		`TypeUser`,
		`CreationDate`,
		`ModificationDate`,
		`Active`
	)

	VALUES
	(
		TypeUser,
		NOW(),
		NOW(),
		Active
	);

END

$$

DELIMITER ;