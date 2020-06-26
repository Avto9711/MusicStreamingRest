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

namespace InnRoadTest.Bl.Services.SongService
{
    public class SongService : BaseCrudService<Song, SongDto>, ISongService, IBaseCrudService<Song, SongDto>
    {
        public SongService(IMapper mapper, IUnitOfWork<IInnRoadTestDbContext> uow) : base(mapper, uow)
        {
        }
    }
}
