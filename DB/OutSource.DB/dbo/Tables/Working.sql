CREATE TABLE [dbo].[Working]
(
	[CaseId] INT NOT NULL ,
	[Id] INT NOT NULL ,
	[Done] NVARCHAR (16) NOT NULL,
	[Asses] NVARCHAR (64)  NULL,
	[Comment] NVARCHAR (64) NULL, 
	CONSTRAINT [PK_Working] PRIMARY KEY CLUSTERED 
	(
	[CaseId],
	[Id]
	) ON [PRIMARY] 
)
