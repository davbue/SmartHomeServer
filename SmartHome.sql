DROP DATABASE IF EXISTS SmartHome;

CREATE DATABASE SmartHome;

USE SmartHome;

CREATE TABLE `Rooms` (
	`RoomId` INT NOT NULL AUTO_INCREMENT,
	`RoomName` VARCHAR(50) NOT NULL,
	PRIMARY KEY (`RoomId`)
) ENGINE=InnoDB;

CREATE TABLE `Devices` (
	`DeviceId` INT NOT NULL AUTO_INCREMENT,
	`DeviceName` VARCHAR(50) NOT NULL,
	`Enabled` BOOLEAN NOT NULL DEFAULT FALSE,
	`Room_RoomId` INT NOT NULL,
	PRIMARY KEY (`DeviceId`),
	FOREIGN KEY (`Room_RoomId`) REFERENCES Rooms(`RoomId`) ON DELETE CASCADE
) ENGINE=InnoDB;