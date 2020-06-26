using AutoMapper;
using InnRoadTest.Bl.Services.BaseControllerService;
using InnRoadTest.Bl.Services.GetEntities;
using InnRoadTest.Bl.ViewModels;
using InnRoadTest.Model.Models;
using InnRoadTest.Model.Context.InnRoadTest;
using InnRoadTest.Model.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using InnRoadTest.Core.Specification;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace InnRoadTest.Bl.Services.AlbumService
{
    public class AlbumService :  BaseCrudService<Album, AlbumDto>, IBaseCrudService<Album, AlbumDto>, IAlbumService
    {
        public AlbumService(IMapper mapper, IUnitOfWork<IInnRoadTestDbContext> uow) : base(mapper, uow)
        {
        }

        public async Task<List<MusicLabelDto>> GetAlbumMusicLabels(int albumId)
        {
            var spec = new BaseSpecification<AlbumMusicLabel>(x => x.AlbumId == albumId);
            spec.AddInclude(x => x.MusicLabel);

            var albumMLabelRepo = _uow.GetRepository<AlbumMusicLabel>();
            var albumMLabelsQuery =  albumMLabelRepo.SpecAsQueryable(spec);
            var musicLabels = await albumMLabelsQuery.Select(y => y.MusicLabel).ToListAsync();
            var dto = Mapper.Map<List<MusicLabelDto>>(musicLabels);
            return dto;
        }

        public async Task<List<SongDto>> GetAlbumTracks(int albumId)
        {
            var spec = new BaseSpecification<Song>(x => x.AlbumId == albumId);
            var songRepo = _uow.GetRepository<Song>();
            var songs = await songRepo.ListAsync(spec);
            var dto = Mapper.Map<List<SongDto>>(songs);
            return dto;
        }
    }
}
