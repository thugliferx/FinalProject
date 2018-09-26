CREATE TABLE [dbo].[AssesLetter]
(
	[Id] INT NOT NULL,
	[AssesAppendix] NVARCHAR (256) NOT NULL,
	[AssesDis] NVARCHAR (256) NOT NULL,
	[AssesId] INT NOT NULL PRIMARY KEY,
	CONSTRAINT [FK_Case_AssesLetter_Id] FOREIGN KEY  ([Id])  REFERENCES [dbo].[Receiver] ([Id])   ON DELETE CASCADE,  
	CONSTRAINT [FK_Receiver_AssesLetter_Id] FOREIGN KEY  ([Id])  REFERENCES [dbo].[Receiver] ([Id])   ON DELETE CASCADE    
)
