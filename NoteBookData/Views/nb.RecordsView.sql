CREATE VIEW nb.RecordsView
	AS 
	SELECT 
		records.Id,
		records.Description,
		IIF(records.CompleteDate IS NULL, 0 , 1) AS IsComplete,
		records.CompleteDate
		FROM nb.Records AS records
