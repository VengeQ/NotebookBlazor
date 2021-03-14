using Notebook.Core;
using Notebook.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notebook.Data.Providers
{

    public class CaseNoteProvider
    {
        private Db _db;

        public CaseNoteProvider(Db db)
        {
            _db = db;
        }

        public IEnumerable<CaseNote> GetCaseNotes()
        {
            return _db.SelectData<CaseNote>("SELECT * FROM nb.CaseNotesView");
        }

        public void MakeComplete(int id)
        {
            var arguments = new Dictionary<String, String>
            {
                { "@Id", id.ToString() }
            };
            _db.ExecuteProcedure("nb.MakeCaseNoteComplete", arguments);
        }
    }
}
