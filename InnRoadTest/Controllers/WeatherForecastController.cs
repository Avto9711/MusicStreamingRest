using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using InnRoadTest.Bl.ViewModels;
using InnRoadTest.Model.Context.InnRoadTest;
using InnRoadTest.Model.Models;
using InnRoadTest.Model.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace InnRoadTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        protected readonly IUnitOfWork<IInnRoadTestDbContext> _uow;
        private readonly IMapper _mapper;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IUnitOfWork<IInnRoadTestDbContext> uow, IMapper mapper)
        {
            _logger = logger;
            _uow = uow;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<AlbumDto>> Get()
        {
            _logger.LogInformation("klk wawawa");
            var list = await _uow.GetRepository<Album>().ListAsync();
            var dto = _mapper.Map<List<AlbumDto>>(list);
            return dto;
        }
    }
}
