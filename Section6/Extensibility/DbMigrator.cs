using System;

namespace Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migration started at: " + DateTime.Now);
            
            //details of migrating the database

            _logger.LogInfo("Migration ended at: " + DateTime.Now);

        }
    }
}