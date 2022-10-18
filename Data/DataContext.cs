using DeckOfCards.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DeckOfCards.Data
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>().HasKey(c => c.Id);
        }
  }
}