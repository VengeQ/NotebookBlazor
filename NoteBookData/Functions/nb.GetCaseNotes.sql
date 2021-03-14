CREATE FUNCTION nb.GetCaseNotes
(
	@JustUncompleted bit = 1
)
RETURNS TABLE
AS
RETURN(
	SELECT
		r.Id,
		r.Description,
		r.IsComplete,
		r.CompleteDate
		FROM nb.CaseNotesView AS r
		WHERE IIF(r.CompleteDate IS NULL, 0 , 1) = @JustUncompleted
)
