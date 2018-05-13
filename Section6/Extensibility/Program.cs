using System;
using System.IO;

namespace Extensibility
{

    class Program
    {
        static void Main(string[] args)
        {
            //var dbMigrator = new DbMigrator(new ConsoleLogger());
            var dbMigrator = new DbMigrator(new FileLogger("/Users/jmcgee/Documents/cSharpIntermediate_Udemy/Section6/Extensibility/log.txt"));

            dbMigrator.Migrate();
        }
    }
}
