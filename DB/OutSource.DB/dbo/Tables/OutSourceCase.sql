CREATE TABLE [dbo].[OutSourceCase]
(
	[CaseId] INT NOT NULL identity(1,1) PRIMARY KEY,
	[CaseName] NVARCHAR (64) NOT NULL,
	[CaseField] NVARCHAR (256) NOT NULL,
	[StartDate] datetime NOT NULL,
	[EndDate] datetime NOT NULL,
	[Price] VARCHAR (64) NOT NULL,
	[Address] NVARCHAR (256) NOT NULL,
	[Requirs] NVARCHAR (256) NOT NULL,
	[ID] INT NULL, 
)
