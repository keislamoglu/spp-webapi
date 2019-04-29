using Entity;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class SppContext : DbContext
    {
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Voter> Voters { get; set; }
        public DbSet<Vote> Votes { get; set; }
        public DbSet<Story> Stories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=../DAL/spp.db");
        }
    }
}