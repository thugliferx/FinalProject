CREATE TABLE [dbo].[FileUpload_DB_Certif]
(
	[FileUpload_DB_CerId] BIGINT identity(1,1) NOT NULL PRIMARY KEY,
	[FileUpload_DB_CerField] NVARCHAR (256)  NULL,
	[FileUpload_FilName] NVARCHAR (256) NOT NULL,
	[UserId] VARCHAR  NULL ,

	--CONSTRAINT [FK_FileUpload_DB_Certif_Users] FOREIGN KEY  ([UserId])  REFERENCES [dbo].[Users] ([Id])   ON DELETE CASCADE    
)
