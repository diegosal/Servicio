/*--------------------------------------------------
---------Create By: Diego Gonzalez------------------
---------Creation Date: 2017-07-05------------------
---------Description: Insert Status-----------------
*/--------------------------------------------------



USE `RMDVCore`;

DROP PROCEDURE IF EXISTS `RMDVCore`.`SYSInsertCatSupplier`;

DELIMITER $$

CREATE PROCEDURE `RMDVCore`.`SYSInsertCatSupplier`

(
	IN SupplierName 		VARCHAR(255),
	IN ContactNumer			VARCHAR(255),
	IN Active				BIT
)

BEGIN

	INSERT INTO `rmdvcore`.`catsupplier`
	(
		`SupplierName`,
		`ContactNumer`,
		`CreationDate`,
		`ModificationDate`,
		`Active`
	)

	VALUES
	(
		SupplierName,
		ContactNumer,
		NOW(),
		NOW(),
		Active
	);

END

$$

DELIMITER ;