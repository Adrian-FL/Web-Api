using Highscores.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Highscores.Data
{
    public class HighscoresContext : DbContext
    {
        //creeaza tabelele in database
        public DbSet<Game> Games { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Highscore> Highscores { get; set; }

        public HighscoresContext(DbContextOptions<HighscoresContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Highscore>().HasKey(hs => new { hs.GameId, hs.PlayerId });
        }
    }
}