using InnRoadTest.Model.Context.InnRoadTest;
using InnRoadTest.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace InnRoadTest.Model.Context
{
    public class InnRoadTestDbContext:DbContext, IInnRoadTestDbContext
    {

        public InnRoadTestDbContext(DbContextOptions<InnRoadTestDbContext> options) : base(options)
        {

        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<AlbumMusicLabel> AlbumMusicLabels { get; set; }
        public DbSet<AlbumRate> AlbumRates { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MusicLabel> MusicLabels { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<T> GetDbSet<T>() where T : class => Set<T>();

    }
}
