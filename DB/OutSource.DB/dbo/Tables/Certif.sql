CREATE TABLE [dbo].[Certif]
(
	[CerId] INT NOT NULL PRIMARY KEY,
	[CerName] NVARCHAR (64) NOT NULL,
	[CerField] NVARCHAR (64) NOT NULL,
	[CerAppendix] NVARCHAR (256) NOT NULL,
	[Id] INT NOT NULL ,
	CONSTRAINT [FK_Receiver_Certif_Id] FOREIGN KEY  ([Id])  REFERENCES [dbo].[Receiver] ([Id])   ON DELETE CASCADE 
)
