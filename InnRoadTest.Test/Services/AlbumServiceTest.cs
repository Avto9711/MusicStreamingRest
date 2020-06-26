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
 
    public class AlbumServiceTest: BaseTestFixture
    {
        IAlbumService service;
        public AlbumServiceTest():base()
        {
            service = AutofacContainer.Resolve<IAlbumService>();
        }

        [Test]
        public async Task GetAlbumTracksByAlbumIdTest()
        {
            var tracks = await service.GetAlbumTracks(1);
            Assert.AreEqual(tracks.Count, 12);
        }

    }
}
