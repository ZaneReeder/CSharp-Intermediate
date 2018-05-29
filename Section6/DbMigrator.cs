using System;

namespace Section6
{

    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        //Db Migrating Details
        public void Migrate()
        {
            _logger.LogInfo("Migration started at " + DateTime.Now);

            _logger.LogInfo("Migration finished at " + DateTime.Now);
        }
    }
}

