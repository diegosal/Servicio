/*----------------------------------------------------
---------Create By: Diego Gonzalez--------------------
---------Creation Date: 2017-07-05--------------------
---------Description: Insert new Event----------------
*/----------------------------------------------------



USE `RMDVCore`;

DROP PROCEDURE IF EXISTS `RMDVCore`.`SYSInsertEvent`;

DELIMITER $$

CREATE PROCEDURE `RMDVCore`.`SYSInsertEvent`

(
	IN UserId 				INT (10),
	IN RecreationalAreaId 	INT (10),
	IN StartDate 			DATETIME,
	IN EndDate 				DATETIME,
	IN Status 				BIT
)

BEGIN

	INSERT INTO `RMDVCore`.`Event`
	(
		`UserId`,
		`RecreationalAreaId`,
		`StartDate`,
		`EndDate`,
		`Status`
	)
	VALUES
	(
		UserId,
		RecreationalAreaId,
		StartDate,
		EndDate,
		Status
    );

END

$$

DELIMITER ;