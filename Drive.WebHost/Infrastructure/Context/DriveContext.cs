using Drive.WebHost.Models;
using System.Data.Entity;

namespace Drive.WebHost.Infrastructure.Context
{
    public class DriveContext : DbContext
    {
        public DriveContext() : base("DriveDB")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<DriveContext>());
        }
        public DbSet<LogEntry> LogEntries { get; set; }
    }
}