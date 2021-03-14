using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Data.Common;
using Microsoft.Extensions.Configuration;

namespace Notebook.Core
{
    public class Db
    {
        private readonly IConfiguration _config;
        public Db(IConfiguration config)
        {
            _config = config;
        }
        public DbConnection GetConnection()
        {
            return new SqlConnection
               (_config.GetConnectionString("DefaultConnection"));
        }

        public IEnumerable<T> SelectData<T>(String query)
        {
            using IDbConnection db = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            return db.Query<T>(query, commandType: CommandType.Text);
        }

        public int Execute<T>(String query)
        {
            using IDbConnection db = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            return db.Execute(query, commandType: CommandType.Text);
        }
        public int ExecuteProcedure(String query, IDictionary<String,String> arguments)
        {
            using IDbConnection db = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            var parameters = new DynamicParameters();
            foreach (var args in arguments)
            {
                parameters.Add(args.Key, args.Value);
            }
            return db.Execute(query, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}
