﻿CREATE TABLE [dbo].[Certif]
(
	[CerId] INT NOT NULL PRIMARY KEY,
	[CerName] NVARCHAR (64) NOT NULL,
	[CerField] NVARCHAR (64) NOT NULL,
	[CerAppendix] NVARCHAR (256) NOT NULL,
	[Id] INT NOT NULL ,
)
