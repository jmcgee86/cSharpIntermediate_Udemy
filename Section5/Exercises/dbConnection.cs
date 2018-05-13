using System;

namespace Exercises_Section5
{
    public abstract class DbConnection
    {
        public string _connectionString { get; private set;}
        public readonly TimeSpan TimeOut = TimeSpan.FromSeconds(45);

       public DbConnection(string connectionString)
       {
           if(String.IsNullOrEmpty(connectionString))
            throw new NullReferenceException("connection string must be entered");
           _connectionString = connectionString;
       }

       public abstract void Open();

       public abstract void Close();
    }

    public class SqlConnection : DbConnection
    {
        public SqlConnection (string connectionString)
            : base (connectionString)
        {
            System.Console.WriteLine("SQL database is initialized with connection string: {0} ", _connectionString);
        }
        public override void Open()
        {
            System.Console.WriteLine("open SQL Connection at {0}", _connectionString);
        }
        public override void Close()
        {
            System.Console.WriteLine("Close SQL Connection");
        }
    }

    public class OracleConnection : DbConnection
    {
         public OracleConnection (string connectionString)
            : base (connectionString)
        {
            System.Console.WriteLine("Oracle database is initialized with connection string: {0}", _connectionString);
        }
     public override void Open()
        {
            System.Console.WriteLine("open Oracle Connection at: {0}", _connectionString);
        }
        public override void Close()
        {
            System.Console.WriteLine("Close Oracle Connection {0}", _connectionString);
        }
    }
}