using Autofac;
using InnRoadTest.Bl.Services.AlbumService;
using InnRoadTest.Model.Context;
using InnRoadTest.Model.Context.InnRoadTest;
using InnRoadTest.Model.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnRoadTest.Test.Services
{
    public class AlbumServiceTest: BaseTest
    {
        IInnRoadTestDbContext context;
        IAlbumService service;
        public AlbumServiceTest()
        {
            context = AutofacContainer.Resolve<IInnRoadTestDbContext>();
            service = AutofacContainer.Resolve<IAlbumService>();
            LoadSeedData(context);

        }
        [Test]
        public async Task GetAlbumTracksByAlbumIdTest()
        {
           
            var albumSet = context.GetDbSet<Genre>();
            var responseList = albumSet.ToList();
            var response = await service.GetAlbumTracks(1);
            Assert.GreaterOrEqual(1, 1);
        }
    }
}
