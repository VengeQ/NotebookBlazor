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

namespace Notebook.Data
{
    public class RecordService
    {
        private Db _db;
        public RecordService(Db db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Record>> GetRecords()
        {
            using IDbConnection db = new SqlConnection("Data Source=DESKTOP-PQSPCPJ\\SQLEXPRESS;Initial Catalog=Notebook;Trusted_Connection=true;MultipleActiveResultSets=True;Integrated Security=True");
            var result = _db.SelectData<Record>("SELECT records.Id FROM nb.Records AS records");
            var t = await db.QueryAsync<Record>("SELECT * FROM nb.GetRecords(0)");
            return t;
        }
    }
}
