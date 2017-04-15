DROP DATABASE IF EXISTS Fragment;

CREATE DATABASE Fragment;

USE Fragment;
CREATE TABLE Guilds
(
	guildID  INT NOT NULL AUTO_INCREMENT,
	guildName VARCHAR(50),
    PRIMARY KEY(guildID)

);

CREATE TABLE GuildMembers
(
	guildMemberID INT NOT NULL AUTO_INCREMENT,
	guildID INT,
	userID INT,
    PRIMARY KEY(guildMemberID)
);

CREATE Table Characters
(
	characterID INT NOT NULL AUTO_INCREMENT,
	characterName VARCHAR(15),
	classID INT,
	characterLevel INT,
	status VARCHAR (8),
	guildID INT,
	Notes VARCHAR (120),
	PRIMARY KEY(characterID)
);

CREATE Table Classes
(
	classID INT NOT NULL AUTO_INCREMENT,
	className VARCHAR(15),
    PRIMARY KEY(classID)
);

INSERT INTO Classes (className) VALUES ('Twin Blade');
INSERT INTO Classes (className) VALUES ('Blademaster');
INSERT INTO Classes (className) VALUES ('Heavy Blade');
INSERT INTO Classes (className) VALUES ('Heavy Axe');
INSERT INTO Classes (className) VALUES ('Long Arm');
INSERT INTO Classes (className) VALUES ('Wavemaster');

CREATE Table Logs
(
	logID INT NOT NULL AUTO_INCREMENT,
	logText VARCHAR(2000),
	logTime DATETIME,
    PRIMARY KEY(logID)
);


CREATE Table Lobbies
(
	lobbyID INT NOT NULL AUTO_INCREMENT,
	lobbyName VARCHAR(10),
    PRIMARY KEY(lobbyID)
);


INSERT INTO Lobbies (lobbyName) VALUES('Main');
INSERT INTO Lobbies (lobbyName) VALUES('Test');

CREATE Table ServerInfo
(
	serverInfoID INT NOT NULL AUTO_INCREMENT,
	welcomeText VARCHAR(500),
	serverStatus VARCHAR(400),
    PRIMARY KEY(serverInfoID)
);
INSERT INTO ServerInfo (welcomeText,serverStatus) VALUES('Welcome to the Fragment Test Server!.','Current Status: Barely working!');

/*Stored Procedures */
USE Fragment;
-- Stored Procedure for inserting a log
-- These could be anything from debug information, exception logging or just anything that the server sends or receives
DROP PROCEDURE IF EXISTS InsertLog;

DELIMITER //
CREATE PROCEDURE InsertLog   
(IN loggedText VARCHAR(2000))
BEGIN 
	INSERT INTO Logs (logText,logTime) VALUES (loggedText,NOW());
END//
DELIMITER ;


-- Stored Procedure for Getting Currently Connected Characters
DROP PROCEDURE IF EXISTS GetCharacters;

DELIMITER //
CREATE PROCEDURE GetCharacters   
()
BEGIN 
	SELECT * FROM Characters;
END//
DELIMITER ;

-- Stored Procedure for getting the Server Info
DROP PROCEDURE IF EXISTS GetServerInfo;
DELIMITER //
CREATE PROCEDURE GetServerInfo   
()
BEGIN 
	SELECT * FROM ServerInfo;
END//
DELIMITER ;