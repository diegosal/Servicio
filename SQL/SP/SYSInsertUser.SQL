/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Insert new user-----------
*/----------------------------------------------

DELIMITER $$

USE `RMDVCore`;

DROP PROCEDURE IF EXISTS `RMDVCore`.`SYSInsertUser`;

CREATE PROCEDURE `RMDVCore`.`SYSInsertUser`

(
	IN CompanyId        int(10),
	IN TypeId           int(10),
	IN UserName         varchar(150),
	IN UserMiddleName   varchar(150),
	IN UserLastName     varchar(150),
	IN UserMotherName   varchar(150),
	IN Email            varchar(255),
	IN PassWord         varchar(12),
	IN CreationDate     datetime,
	IN ModificationDate datetime,
	IN Active           bit(1) 
)

BEGIN

	INSERT INTO `rmdvcore`.`user`
	
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
		CreationDate,
		ModificationDate,
		Active
	);
END

$$

DELIMITER ;