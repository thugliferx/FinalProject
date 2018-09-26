CREATE TABLE [dbo].[Users]
(
	[Id] VARCHAR NOT NULL PRIMARY KEY ,
	[account_number] NVARCHAR (64)  NOT NULL,
	[Name] NVARCHAR (64)  NOT NULL,
	[CellPhone] NVARCHAR (20) NOT NULL,
	[Email] NVARCHAR (20) NOT NULL,
	[Pwd] NVARCHAR (64)  NOT NULL,
	[City] NVARCHAR (64) NOT NULL,
	[Address] NVARCHAR (256) NOT NULL,
	[Birth] datetime NOT NULL, 
	[AuthenCard] NVARCHAR (64) NOT NULL,



	

)
