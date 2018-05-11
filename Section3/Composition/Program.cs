using System;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            var DBMigrator = new DBMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            DBMigrator.Migrate();

            installer.Install();
        }
    }
}
