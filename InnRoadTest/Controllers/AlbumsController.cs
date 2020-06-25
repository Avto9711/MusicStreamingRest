using AutoMapper;
using InnRoadTest.Bl.ViewModels;
using InnRoadTest.Model.Models;
using InnRoadTest.Model.Context.InnRoadTest;
using InnRoadTest.Model.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InnRoadTest.Controllers
{
    public class AlbumsController : BaseController<Album, AlbumDto>
    {
        public AlbumsController(IMapper mapper, IUnitOfWork<IInnRoadTestDbContext> uow) : base(mapper, uow)
        {
        }
    }
}
