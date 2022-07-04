using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEACHER
{
    public static class Helper
    {

        public static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString;
        }

        public static IEnumerable<T> Query<T>(string connectionString, string sql, object param = null, CommandType commandType = CommandType.StoredProcedure)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                return connection.Query<T>(sql, param, commandType: commandType, commandTimeout: 3000);
            }
        }
    }
}
