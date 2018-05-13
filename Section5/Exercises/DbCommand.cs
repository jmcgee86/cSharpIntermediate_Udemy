using System;
namespace Exercises_Section5
{
    public class DbCommand
    {
    private DbConnection openConnection{ get;  set;}
        private string _instruction {get; set;}

        public DbCommand(DbConnection connection, string instruction)
        {
            if (string.IsNullOrEmpty(instruction))
                throw new NullReferenceException("must provide Database connection and instruction");
            _instruction = instruction;
            openConnection = connection;
        }

        public void Execute()
        {
            openConnection.Open();
            System.Console.WriteLine("Run this command: {0}", _instruction);
            openConnection.Close();
        }
    }
}