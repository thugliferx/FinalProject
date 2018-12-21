CREATE TABLE [dbo].[Users]
(
	[Id]  BIGINT identity(1,1) NOT NULL PRIMARY KEY,
	[Name] NVARCHAR (64)  NOT NULL,
	[CellPhone] NVARCHAR (20) NULL,
	[Email] NVARCHAR (50) NOT NULL,
	[Pwd] NVARCHAR (64)  NOT NULL,
	[City] NVARCHAR (64) NULL,
	[Address] NVARCHAR (256) NULL,
	[Birth] datetime NULL, 
	[AuthenCard] NVARCHAR (64) NULL,



	

)
