using System;

namespace Exercises_Section5
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlDatabase = new SqlConnection("sql/string/connection");
            var sqlCommand = new DbCommand(sqlDatabase, "query sql");
            sqlCommand.Execute();

            var oracleDatabase = new OracleConnection("oracle/string/connection");
            var oracleCommand = new DbCommand(oracleDatabase, "query oracle");
            oracleCommand.Execute();

        }
    }
}
