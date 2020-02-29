using StudentTrackingSoftware.Data.Contexts;
using System.Data.Entity.Migrations;

namespace StudentTrackingSoftware.Data.StudentTrackingMigration
{
    public  class Configuration:DbMigrationsConfiguration<StudentTrackingContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}
