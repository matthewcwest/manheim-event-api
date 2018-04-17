using System.Data.Entity;
using ManheimEventApi.Models.Units;
using ManheimEventApi.Models.Offerings;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ManheimEventApi.DataAccess
{
    // DbContext for Entity Framework. The class name should map to the connection string in the web.config.
    public class DbContext : System.Data.Entity.DbContext
    {
        public DbSet<Unit> Unit { get; set; }

        public DbSet<Offering> Offering { get; set; }

        public DbSet<ConditionReport> ConditionReport { get; set; }

        public DbSet<PriorPaint> PriorPaint { get; set; }

        public DbSet<Images> Images { get; set; }

        public DbSet<Audio> Audio { get; set; }

        public DbSet<Options> Options { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}