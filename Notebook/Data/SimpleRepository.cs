using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace Notebook.Data
{
    public class SimpleRepository
    {
        private readonly string connection = null;

        public SimpleRepository(String connection)
        {
            this.connection = connection;
        }

        public async Task<RecordFromDB> DoSomething()
        {
            using IDbConnection db = new SqlConnection(connection);
            return await db.QueryFirstAsync<RecordFromDB>("SELECT * FROM nb.GetRecords(0)");
        }

        public class RecordFromDB
        {
            public int Id { get; set; }
            public String Description { get; set; }
            public bool IsCompleted { get; set; }
            public DateTime CompleteDate { get; set; }
        }
    }
}
