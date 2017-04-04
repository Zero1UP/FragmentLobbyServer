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
	characterName VARCHAR(15),
	classID INT,
	characterLevel INT,
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