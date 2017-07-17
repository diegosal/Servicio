/*----------------------------------------------
---------Create By: Diego Gonzalez--------------
---------Creation Date: 2017-07-05--------------
---------Description: Insert new Ticket---------
*/----------------------------------------------



USE `RMDVCore`;

DROP PROCEDURE IF EXISTS `RMDVCore`.`SYSInsertTicket`;

DELIMITER $$

CREATE PROCEDURE `RMDVCore`.`SYSInsertTicket`

(
	IN UserId 			 INT(10) UNSIGNED,
	IN EventualityId	 INT(10) UNSIGNED,
	IN StatusId			 INT(10) UNSIGNED
)

BEGIN

	INSERT INTO `RMDVCore`.`Ticket`
	(
		`UserId`,
		`EventualityId`,
		`StatusId`,
		`CreationDate`,
		`ModificationDate`
	)

	VALUES
	(
		UserId,
		EventualityId,
		StatusId,
		NOW(),
		NOW()
	);
	
END

$$

DELIMITER ;