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

namespace InnRoadTest.Bl.Services.AlbumService
{
    public class AlbumService : BaseControllerService<Album, AlbumDto>, IAlbumService<Album, AlbumDto>
    {
        public AlbumService(IMapper mapper, IUnitOfWork<IInnRoadTestDbContext> uow) : base(mapper, uow)
        {
        }
    }
}
