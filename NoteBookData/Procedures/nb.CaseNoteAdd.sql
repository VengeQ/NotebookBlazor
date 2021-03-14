CREATE PROCEDURE nb.CaseNoteAdd
	@Description varchar(200)
AS
BEGIN
	INSERT INTO nb.CaseNotes (Description) VALUES (@Description)
END