USE [master];
DROP DATABASE IF EXISTS Fragment;


CREATE DATABASE Fragment;
GO


CREATE TABLE Fragment.dbo.Guilds
(
	guildID  INT IDENTITY(1,1) PRIMARY KEY,
	guildName VARCHAR(50)

);


CREATE TABLE Fragment.dbo.GuildMembers
(
	guildMemberID INT IDENTITY(1,1) PRIMARY KEY,
	guildID INT,
	userID INT
);

CREATE Table Fragment.dbo.Characters
(
	characterID INT IDENTITY(1,1) PRIMARY KEY,
	characterSaveSlot INT,
	characterSaveID VARCHAR(44),
	characterName VARCHAR(15),
	classID INT,
	characterLevel INT,
	characterGreeting VARCHAR(250),
	characterHP INT,
	characterSP INT,
	characterGP INT,
	characterOnlineGotCounter INT,
	characterOfflineGotCounter INT,
	status VARCHAR (8),
	guildID INT,
	Notes VARCHAR (120)
);

CREATE Table Fragment.dbo.Classes
(
	classID INT IDENTITY(1,1) PRIMARY KEY,
	className VARCHAR(15)
);

INSERT INTO Fragment.dbo.Classes VALUES ('Twin Blade');
INSERT INTO Fragment.dbo.Classes VALUES ('Blademaster');
INSERT INTO Fragment.dbo.Classes VALUES ('Heavy Blade');
INSERT INTO Fragment.dbo.Classes VALUES ('Heavy Axe');
INSERT INTO Fragment.dbo.Classes VALUES ('Long Arm');
INSERT INTO Fragment.dbo.Classes VALUES ('Wavemaster');


CREATE Table Fragment.dbo.Logs
(
	logID INT IDENTITY(1,1) PRIMARY KEY,
	logText VARCHAR(2000),
	logTime DATETIME
);


CREATE Table Fragment.dbo.Lobbies
(
	lobbyID INT IDENTITY(1,1) PRIMARY KEY,
	lobbyName VARCHAR(10)
)


INSERT INTO Fragment.dbo.Lobbies VALUES('Main');
INSERT INTO Fragment.dbo.Lobbies VALUES('Test');

CREATE Table Fragment.dbo.ServerInfo
(
	serverInfoID INT IDENTITY(1,1) PRIMARY KEY,
	welcomeText VARCHAR(500),
	serverStatus VARCHAR(400)
)
INSERT INTO Fragment.dbo.ServerInfo VALUES('Welcome to the Fragment Test Server!.','Current Status: Barely working!');

/*Stored Procedures */
USE Fragment;
GO
--Stored Procedure for inserting a log
--These could be anything from debug information, exception logging or just anything that the server sends or receives
DROP PROCEDURE IF EXISTS InsertLog;

GO
CREATE PROCEDURE InsertLog   
    @logText VARCHAR(2000)  
AS   
	INSERT INTO Fragment.dbo.Logs (logText,logTime) VALUES (@logText,GETDATE());
GO

--Stored Procedure for Getting Currently Connected Characters
DROP PROCEDURE IF EXISTS GetCharacters;

GO
CREATE PROCEDURE GetCharacters   
 
AS   
	SELECT * FROM Characters
GO  

--Stored Procedure for getting the Server Info
DROP PROCEDURE IF EXISTS GetServerInfo;

GO
CREATE PROCEDURE GetServerInfo   
 
 AS   
	SELECT * FROM ServerInfo;
GO

--Stored Procedure for getting the list of Lobbies
DROP PROCEDURE IF EXISTS GetLobbies;

GO
CREATE PROCEDURE GetLobbies   
 
 AS   
	SELECT * FROM Lobbies;
GO

--Stored Procedure for getting the list of information for all Characters
DROP PROCEDURE IF EXISTS GetAllCharacterInformation;

GO
CREATE PROCEDURE GetAllCharacterInformation   
 
 AS   
	SELECT 
			characterID,
			characterName,
			className,
			characterLevel,
			characterGreeting,
			characterHP,
			characterSP,
			characterGP,
			characterOnlineGotCounter,
			characterOfflineGotCounter,
			status,
			guildName,
			Notes
	FROM 
		Characters
	JOIN
		Classes
	ON
		Classes.classID = characters.classID
	JOIN
		guilds
	ON
		guilds.guildID = Characters.guildID;

GO

--Stored Procedure for getting the list of information for a Character
DROP PROCEDURE IF EXISTS GetCharacterInformation;

GO
CREATE PROCEDURE GetCharacterInformation   
  @CharacterID int
 AS   
 	SELECT 
			characterID,
			characterName,
			className,
			characterLevel,
			characterGreeting,
			characterHP,
			characterSP,
			characterGP,
			characterOnlineGotCounter,
			characterOfflineGotCounter,
			status,
			guildName,
			Notes
	FROM 
		Characters
	JOIN
		Classes
	ON
		Classes.classID = characters.classID
	JOIN
		guilds
	ON
		guilds.guildID = Characters.guildID
	WHERE 
		CharacterID =@CharacterID;
GO

--Stored Procedure for getting a count of characters per class
DROP PROCEDURE IF EXISTS GetClassCount;

GO
CREATE PROCEDURE GetClassCount   
 
 AS   
 	SELECT 
		className,
		COUNT(characterID)
	FROM
		Classes
	JOIN
		Characters
	ON
		Classes.classID = Characters.classID
	GROUP BY className;
GO
