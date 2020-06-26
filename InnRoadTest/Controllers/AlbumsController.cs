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
using InnRoadTest.Bl.Services.AlbumService;
using Microsoft.AspNetCore.Mvc;

namespace InnRoadTest.Controllers
{
    public class AlbumsController : BaseController<Album, AlbumDto>
    {
        private readonly IAlbumService _albumService;
        public AlbumsController(IBaseCrudService<Album, AlbumDto> baseControllerService, IAlbumService albumService) : base(baseControllerService)
        {
            _albumService = albumService;
        }
        //private IAlbumService _baseControllerService;
        ////public AlbumsController(IAlbumService<Album, AlbumDto> baseControllerService) : base(baseControllerService)
        //{
        //    _baseControllerService = baseControllerService;
        //}

        [HttpGet]
        public async override Task<IActionResult> Get()
        {
            return Ok(await BaseControllerService.GetEntities(x => x.Artist, x => x.AlbumRates, x => x.Genre));
        }

        [HttpGet("{id}")]
        public async override Task<IActionResult> GetById(int id)
        {
            var dto = await BaseControllerService.GetById(id, x => x.Artist, x => x.AlbumRates, x => x.Genre);

            if (dto is null)
                return NotFound();

            return Ok(dto);
        }

        [HttpGet("{albumId}/songs")]
        public async Task<IActionResult> GetAlbumSongs(int albumId)
        {
            var dto = await _albumService.GetAlbumTracks(albumId);
            return Ok(dto);
        }
    }
}
