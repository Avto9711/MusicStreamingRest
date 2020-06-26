using Autofac;
using InnRoadTest.Bl.Services.GetEntities;
using InnRoadTest.Bl.ViewModels;
using InnRoadTest.Model.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnRoadTest.Test.BaseCrudService
{
    public class AlbumBaseCrudServiceTest: BaseTestFixture
    {
        IBaseCrudService<Album, AlbumDto> service;
        public AlbumBaseCrudServiceTest()
        {
            service = AutofacContainer.Resolve<IBaseCrudService<Album, AlbumDto>>();
        }

        [Test]
        public async Task GetAlbumEntitiesTest()
        {
            var response = await service.GetEntities();
            Assert.Greater(response.Count, 0);
        }

        [Test]
        public async Task CreateAlbumEntityTest()
        {
            string albumTestName = "test";
            var response = await service.CreateEntity(new AlbumDto { Id = 2,GenreId = 1, Price = 9.6, Name = albumTestName, ArtistId = 1, ReleaseDate = DateTime.Now, Review="asasd"});

            var entities = await service.GetEntities();
            Assert.True(entities.Any(y=>y.Name == albumTestName));
        }
    }
}
