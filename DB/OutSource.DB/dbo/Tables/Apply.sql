CREATE TABLE [dbo].[Apply]
(
	[CaseId] INT NOT NULL,
	[Id] INT NOT NULL,
	[State] NVARCHAR (256) NOT NULL,
	[Evalution] VARCHAR (64),
	[Comment] NVARCHAR (256),
	CONSTRAINT [PK_Apply] PRIMARY KEY NONCLUSTERED ([CaseId],[Id]),  
	CONSTRAINT [FK_Case_Apply_CaseId] FOREIGN KEY  ([CaseId])  REFERENCES [dbo].[Case] ([CaseId])   ON DELETE CASCADE,  
	CONSTRAINT [FK_Receiver_Apply_RecId] FOREIGN KEY  ([Id])  REFERENCES [dbo].[Receiver] ([Id])   ON DELETE CASCADE   

)
