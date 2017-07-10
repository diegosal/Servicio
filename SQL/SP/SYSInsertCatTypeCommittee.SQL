/*--------------------------------------------------
---------Create By: Diego Gonzalez------------------
---------Creation Date: 2017-07-05------------------
---------Description: Insert Type Committee---------
*/--------------------------------------------------



USE `RMDVCore`;

DROP PROCEDURE IF EXISTS `RMDVCore`.`SYSInsertCatTypeCommittee`;

DELIMITER $$

CREATE PROCEDURE `RMDVCore`.`SYSInsertCatTypeCommittee`

(
	IN TypeCommittee		VARCHAR(255),
	IN Active				BIT
)

BEGIN

	INSERT INTO `rmdvcore`.`cattypecommittee`
	(
		`TypeCommittee`,
		`CreationDate`,
		`ModificationDate`,
		`Active`
    )

	VALUES
	(
		TypeCommittee,
		NOW(),
		NOW(),
		Active
	);

END

$$

DELIMITER ;