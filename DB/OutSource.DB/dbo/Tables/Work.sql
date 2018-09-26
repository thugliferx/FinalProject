﻿CREATE TABLE [dbo].[Work]
(
	[WorkId] INT NOT NULL PRIMARY KEY,
	[RecId] INT NOT NULL PRIMARY KEY,
	[WorkName] NVARCHAR (64) NOT NULL,
	[WorkAppentix] NVARCHAR (256) NOT NULL,
	[WorkDes] NVARCHAR (256) NOT NULL,
	CONSTRAINT [PK_Work] PRIMARY KEY NONCLUSTERED ([WorkId],[RecId]),  
	CONSTRAINT [FK_Case_Work_WorkId] FOREIGN KEY  ([WorkId])  REFERENCES [dbo].[Receiver] ([RecId])   ON DELETE CASCADE,  
	CONSTRAINT [FK_Receiver_Work_RecId] FOREIGN KEY  ([RecId])  REFERENCES [dbo].[Receiver] ([RecId])   ON DELETE CASCADE    

)
