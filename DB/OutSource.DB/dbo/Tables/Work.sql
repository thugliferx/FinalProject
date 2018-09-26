CREATE TABLE [dbo].[Work]
(
	[WorkId] INT NOT NULL PRIMARY KEY,
	[WorkName] NVARCHAR (64) NOT NULL,
	[WorkAppentix] NVARCHAR (256) NOT NULL,
	[WorkDes] NVARCHAR (256) NOT NULL,
	[Id] INT NOT NULL, 
	CONSTRAINT [FK_Receiver_Work_Id] FOREIGN KEY  ([Id])  REFERENCES [dbo].[Receiver] ([Id])   ON DELETE CASCADE    

)
