using Notebook.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Notebook.Entities;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Dapper;
using Notebook.Data.Providers;

namespace Notebook.Data
{
    public class CaseNoteService
    {
        private CaseNoteProvider _provider;
        public CaseNoteService(CaseNoteProvider provider)
        {
            _provider = provider;
        }
        public async Task<IEnumerable<CaseNote>> GetCaseNotes()
        {
            return _provider.GetCaseNotes();
        }
    }
}
