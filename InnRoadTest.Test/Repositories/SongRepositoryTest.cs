using Autofac;
using InnRoadTest.Model.Repositories.SongRepository;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InnRoadTest.Test.Repositories
{
    public class SongRepositoryTest : BaseTestFixture
    {
        private ISongRepository _repo;

        public SongRepositoryTest()
        {
            _repo = AutofacContainer.Resolve<ISongRepository>();
        }

        [Test]
        public async Task ReproduceSong()
        {
            _repo.ReproduceSong(new Model.Models.Song { });
            Assert.IsTrue(true);
        }
    }
}
