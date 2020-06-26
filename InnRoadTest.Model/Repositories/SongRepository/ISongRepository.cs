using InnRoadTest.Core.Base;
using InnRoadTest.Core.Shared;
using InnRoadTest.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnRoadTest.Model.Repositories.SongRepository
{
    public interface ISongRepository: IBaseRepository<Song>
    {
        public void ReproduceSong(Song song);
    }
}
