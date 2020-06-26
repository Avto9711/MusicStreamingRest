using InnRoadTest.Model.Base;
using InnRoadTest.Model.Models;
using InnRoadTest.Model.Context.InnRoadTest;
using InnRoadTest.Model.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using InnRoadTest.Core.Base;
using System.Linq;

namespace InnRoadTest.Model.Repositories.SongRepository
{
    public class SongRepository : BaseRepository<Song>, ISongRepository 
    {
        public SongRepository(IUnitOfWork<IInnRoadTestDbContext> uow) : base(uow)
        {
        }

        public void ReproduceSong(Song song)
        {
            //maybe find song
            _context.GetDbSet<Song>().FirstOrDefault(x=>x.Id == song.Id);
        }
    }
}
