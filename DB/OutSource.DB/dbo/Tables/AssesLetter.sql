CREATE TABLE [dbo].[AssesLetter]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[AssesAppendix] NVARCHAR (256) NOT NULL,
	[AssesDis] NVARCHAR (256) NOT NULL,
	[RecId] INT NOT NULL PRIMARY KEY,
	CONSTRAINT [PK_AssesLetter] PRIMARY KEY NONCLUSTERED ([Id],[RecId]),  
	CONSTRAINT [FK_Case_AssesLetter_Id] FOREIGN KEY  ([Id])  REFERENCES [dbo].[Receiver] ([RecId])   ON DELETE CASCADE,  
	CONSTRAINT [FK_Receiver_AssesLetter_RecId] FOREIGN KEY  ([RecId])  REFERENCES [dbo].[Receiver] ([RecId])   ON DELETE CASCADE    
)
