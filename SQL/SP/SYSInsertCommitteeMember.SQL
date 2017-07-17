/*----------------------------------------------------
---------Create By: Diego Gonzalez--------------------
---------Creation Date: 2017-07-05--------------------
---------Description: Insert new Committee Member-----
*/----------------------------------------------------



USE `RMDVCore`;

DROP PROCEDURE IF EXISTS `RMDVCore`.`SYSInsertCommitteeMember`;

DELIMITER $$

CREATE PROCEDURE `RMDVCore`.`SYSInsertCommitteeMember`

(
	IN UserId 			 	INT(10) UNSIGNED,
	IN CommitteeTypeId	 	INT(10) UNSIGNED,
	IN Active				BIT
)

BEGIN

	INSERT INTO `RMDVCore`.`CommitteeMember`
	(
		`UserId`,
        `CommitteeTypeId`,
		`CreationDate`,
		`ModificationDate`,
		`Active`
	)

	VALUES
	(
		UserId,
        CommitteeTypeId,
		NOW(),
		NOW(),
		Active
	);

END

$$

DELIMITER ;