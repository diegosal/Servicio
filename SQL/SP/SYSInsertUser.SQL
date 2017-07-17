/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Insert new User-----------
*/----------------------------------------------



USE `RMDVCore`;

DROP PROCEDURE IF EXISTS `RMDVCore`.`SYSInsertUser`;

DELIMITER $$

CREATE PROCEDURE `RMDVCore`.`SYSInsertUser`

(
	IN CompanyId        INT(10) UNSIGNED,
	IN TypeId           INT(10) UNSIGNED,
	IN UserName         VARCHAR(150),
	IN UserMiddleName   VARCHAR(150),
	IN UserLastName     VARCHAR(150),
	IN UserMotherName   VARCHAR(150),
	IN Email            VARCHAR(255),
	IN PassWord         VARCHAR(12),
	IN Active           BIT 
)

BEGIN

	INSERT INTO `RMDVCore`.`User`
	
	(
		`CompanyId`,
		`TypeId`,
		`UserName`,
		`UserMiddleName`,
		`UserLastName`,
		`UserMotherName`,
		`Email`,
		`PassWord`,
		`CreationDate`,
		`ModificationDate`,
		`Active`
	)

	VALUES
	
	(
		CompanyId,
		TypeId,
		UserName,
		UserMiddleName,
		UserLastName,
		UserMotherName,
		Email,
		PassWord,
		NOW(),
		NOW(),
		Active
	);
	
END

$$

DELIMITER ;