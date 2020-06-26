using AutoMapper;
using InnRoadTest.Bl.Services.BaseControllerService;
using InnRoadTest.Bl.Services.GetEntities;
using InnRoadTest.Bl.ViewModels;
using InnRoadTest.Model.Models;
using InnRoadTest.Model.Context.InnRoadTest;
using InnRoadTest.Model.UnitOfWork;
using InnRoadTest.Model.Repositories.SongRepository;

namespace InnRoadTest.Bl.Services.SongService
{

    public class SongService : BaseCrudService<Song, SongDto>, ISongService, IBaseCrudService<Song, SongDto>
    {
        ISongRepository _songRepo;
        public SongService(IMapper mapper, IUnitOfWork<IInnRoadTestDbContext> uow, ISongRepository songRepo) : base(mapper, uow)
        {
            _songRepo = songRepo;
        }

        public void ReproduceSong(Song song)
        {
            _songRepo.ReproduceSong(song);
        }
    }
}
