using InnRoadTest.Bl.Services.GetEntities;
using InnRoadTest.Bl.ViewModels;
using InnRoadTest.Core.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InnRoadTest.Bl.Services.AlbumService
{
    public interface IAlbumService
    {
        Task<List<SongDto>> GetAlbumTracks(int albumId);
    }
}
