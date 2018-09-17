CREATE TABLE [dbo].[Apply]
(
	[CaseId] INT NOT NULL,
	[RecId] INT NOT NULL,
	[State] NVARCHAR (256) NOT NULL,
	CONSTRAINT [PK_Apply] PRIMARY KEY NONCLUSTERED ([CaseId],[RecId]),  
	CONSTRAINT [FK_Case_Apply_CaseId] FOREIGN KEY  ([CaseId])  REFERENCES [dbo].[Case] ([Id])   ON DELETE CASCADE,  
	CONSTRAINT [FK_Receiver_Apply_RecId] FOREIGN KEY  ([RecId])  REFERENCES [dbo].[Receiver] ([RecId])   ON DELETE CASCADE    

)
