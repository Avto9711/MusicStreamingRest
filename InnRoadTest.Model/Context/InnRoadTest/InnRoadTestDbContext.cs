using InnRoadTest.Model.Context.InnRoadTest;
using InnRoadTest.Model.Models;
using InnRoadTest.Model.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace InnRoadTest.Model.Context
{
    public class InnRoadTestDbContext:DbContext, IInnRoadTestDbContext
    {

        public InnRoadTestDbContext(DbContextOptions<InnRoadTestDbContext> options) : base(options)
        {
            //AddRange
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<AlbumMusicLabel> AlbumMusicLabels { get; set; }
        public DbSet<AlbumRate> AlbumRates { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MusicLabel> MusicLabels { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<T> GetDbSet<T>() where T : class => Set<T>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(SeedData.GenreSeed);
            modelBuilder.Entity<MusicLabel>().HasData(SeedData.MusicLabelSeed);
            modelBuilder.Entity<Artist>().HasData(SeedData.ArtistSeed);
            modelBuilder.Entity<Album>().HasData(SeedData.AlbumSeed);
            modelBuilder.Entity<AlbumMusicLabel>().HasData(SeedData.AlbumMusicLabelSeed);
            modelBuilder.Entity<AlbumRate>().HasData(SeedData.AlbumRatesSeed);
            modelBuilder.Entity<Song>().HasData(SeedData.SongsSeed);

            base.OnModelCreating(modelBuilder);
        }
    }
}
