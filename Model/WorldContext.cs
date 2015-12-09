using Microsoft.Data.Entity;

namespace TheWorld.Model
{
    public class IWorldContext : DbContext
    {
        public IWorldContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Stop> Stops { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder) {
            var connectionString = Startup.Configuration["Data:WorldContextConnection"];

            optionBuilder.UseSqlServer(connectionString);

            base.OnConfiguring(optionBuilder);
        }
    }
}
