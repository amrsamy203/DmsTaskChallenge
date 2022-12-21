using DmsTaskChallenge.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DmsTaskChallenge.Repository.Data
{
    public class DmsTaskChallengeContext : DbContext
    {
        public DmsTaskChallengeContext(DbContextOptions options) : base(options) { }


        #region Entites Regions
        public DbSet<Item> Items { get; set; }
        public DbSet<Uom> Uoms { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
