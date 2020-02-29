using StudentTrackingSoftware.Data.StudentTrackingMigration;
using StudentTrackingSoftware.Model.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace StudentTrackingSoftware.Data.Contexts
{



    public class StudentTrackingContext : BaseDbContext<StudentTrackingContext,Configuration>
    {
        public StudentTrackingContext()
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public StudentTrackingContext(string connectionString) : base(connectionString)
        {
            Configuration.LazyLoadingEnabled = false;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
        public DbSet<City> City { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<School> School { get; set; }
    }
}