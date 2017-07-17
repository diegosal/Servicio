/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Insert new Type Visit-----
*/----------------------------------------------



USE `RMDVCore`;

DROP PROCEDURE IF EXISTS `RMDVCore`.`SYSInsertCatTypeVisit`;

DELIMITER $$

CREATE PROCEDURE `RMDVCore`.`SYSInsertCatTypeVisit`

(
	IN TypeVisit			VARCHAR(255),
	IN Active				BIT
)

BEGIN

	INSERT INTO `RMDVCore`.`CatTypeVisit`
	(
		`TypeVisit`,
		`CreationDate`,
		`ModificationDate`,
		`Active`
	)

	VALUES
	(
		TypeVisit,
		NOW(),
		NOW(),
		Active
	);

END

$$

DELIMITER ;