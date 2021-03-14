CREATE PROCEDURE nb.MakeCaseNoteComplete
	@Id int
AS
BEGIN
	UPDATE cn 
		SET cn.CompleteDate =GETDATE()
		FROM nb.CaseNotes AS cn 
		WHERE cn.Id = @Id
END

