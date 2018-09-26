CREATE TABLE [dbo].[Working]
(
	[CaseId] INT NOT NULL PRIMARY KEY,
	[RecId] INT NOT NULL PRIMARY KEY,
	[Done] NVARCHAR (16) NOT NULL,
	[Asses] NVARCHAR (64)  NULL,
	[Comment] NVARCHAR (64) NULL, 
	CONSTRAINT [PK_Working] PRIMARY KEY NONCLUSTERED ([CaseId],[RecId]),  
	CONSTRAINT [FK_Case_Working_CaseId] FOREIGN KEY  ([CaseId])  REFERENCES [dbo].[Receiver] ([RecId])   ON DELETE CASCADE,  
	CONSTRAINT [FK_Receiver_Working_RecId] FOREIGN KEY  ([RecId])  REFERENCES [dbo].[Receiver] ([RecId])   ON DELETE CASCADE    
)
