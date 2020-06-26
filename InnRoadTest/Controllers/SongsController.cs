using AutoMapper;
using InnRoadTest.Bl.ViewModels;
using InnRoadTest.Model.Models;
using InnRoadTest.Model.Context.InnRoadTest;
using InnRoadTest.Model.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InnRoadTest.Bl.Services.GetEntities;
using InnRoadTest.Bl.Services.SongService;

namespace InnRoadTest.Controllers
{
    public class SongsController : BaseController<Song, SongDto>
    {
        //public SongsController(ISongService baseControllerService) : base(baseControllerService)
        //{
        //}
        public SongsController(IBaseCrudService<Song, SongDto> baseControllerService) : base(baseControllerService)
        {
        }
    }
}
