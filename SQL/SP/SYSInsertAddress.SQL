/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Insert new Address--------
*/----------------------------------------------



USE `RMDVCore`;

DROP PROCEDURE IF EXISTS `RMDVCore`.`SYSInsertAddress`;

DELIMITER $$

CREATE PROCEDURE `RMDVCore`.`SYSInsertAddress`

(
	IN UserId 			INT(10),
	IN StreetName 		VARCHAR(255),
	IN Number 			VARCHAR(10),
	IN PostalCode 		VARCHAR(10),
	IN Active 			BIT
)

BEGIN

	INSERT INTO `rmdvcore`.`address`
	(
		`Id`,
		`UserId`,
		`StreetName`,
		`Number`,
		`PostalCode`,
		`Active`
    )
    
	VALUES
	(
		UserId,
		StreetName,
		Number,
		PostalCode,
		NOW(),
		NOW(),
		Active
    );

END

$$

DELIMITER ;