CREATE TABLE [dbo].[Working]
(
	[CaseId] INT NOT NULL ,
	[Id] INT NOT NULL ,
	[Done] NVARCHAR (16) NOT NULL,
	[Creater's_Asses] NVARCHAR (64)  NULL,
	[Creater's_Comment] NVARCHAR (64) NULL,
	[Receiver's_Asses] NVARCHAR (64)  NULL,
	[Receiver's_Comment] NVARCHAR (64) NULL, 
	CONSTRAINT [PK_Working] PRIMARY KEY CLUSTERED 
	(
	[CaseId],
	[Id]
	) ON [PRIMARY] 
)
