﻿CREATE TABLE [dbo].[Work]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[WorkName] NVARCHAR (64) NOT NULL,
	[WorkAppentix] NVARCHAR (256) NOT NULL,
	[WorkDes] NVARCHAR (256) NOT NULL,
	[RecId] INT NOT NULL PRIMARY KEY,
)