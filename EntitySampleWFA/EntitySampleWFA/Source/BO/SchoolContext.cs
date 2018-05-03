using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EntitySampleWFA.Source.BO
{
    internal class SchoolContext : DbContext
    {
        internal SchoolContext()
            : base("name=SchoolContext")
        {
            base.Database.Log = new System.Action<string>(s => {

            });
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Standard> Standards { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Log> Logs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //base.OnModelCreating(modelBuilder);
        }
    }
}