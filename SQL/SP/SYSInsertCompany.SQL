/*----------------------------------------------------
---------Create By: Diego Gonzalez--------------------
---------Creation Date: 2017-07-05--------------------
---------Description: Insert new Company--------------
*/----------------------------------------------------



USE `RMDVCore`;

DROP PROCEDURE IF EXISTS `RMDVCore`.`SYSInsertCompany`;

DELIMITER $$

CREATE PROCEDURE `RMDVCore`.`SYSInsertCompany`

(
	IN CompanyName 			VARCHAR(255),
	IN Active				BIT
)

BEGIN

	INSERT INTO `RMDVCore`.`Company`
	(
        `CompanyName`,
		`CreationDate`,
		`ModificationDate`,
		`Active`
	)

	VALUES
	(
		CompanyName,
		NOW(),
		NOW(),
		Active
	);

END

$$

DELIMITER ;