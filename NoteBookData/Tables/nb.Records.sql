CREATE TABLE nb.Records
(
	Id int NOT NULL IDENTITY(1,1) PRIMARY KEY CLUSTERED,
	[Description] varchar(200) NOT NULL,
	CompleteDate datetime DEFAULT NULL,
	InsertStamp datetime NOT NULL DEFAULT GETDATE(),
	EditStamp datetime DEFAULT NULL
)
GO;
