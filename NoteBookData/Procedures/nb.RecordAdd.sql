CREATE PROCEDURE nb.RecordAdd
	@Description varchar(200)
AS
BEGIN
	INSERT INTO nb.Records (Description) VALUES (@Description)
END