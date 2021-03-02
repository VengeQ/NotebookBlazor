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

        public async Task<int> DoSomething()
        {
            using IDbConnection db = new SqlConnection(connection);
            return await db.QueryFirstAsync<int>("SELECT COUNT(1) FROM nb.TestTable");
        }
    }
}
