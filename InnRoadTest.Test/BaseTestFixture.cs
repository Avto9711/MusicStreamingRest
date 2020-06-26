using Autofac;
using InnRoadTest.Bl.Services.AlbumService;
using InnRoadTest.Model.Context.InnRoadTest;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnRoadTest.Test
{
    /// <summary>
    /// https://github.com/nunit/docs/wiki/Attributes
    /// </summary>
    public class BaseTestFixture : BaseTest
    {
        IInnRoadTestDbContext context;
        public BaseTestFixture()
        {
            //context = AutofacContainer.Resolve<IInnRoadTestDbContext>();
            //service = AutofacContainer.Resolve<IAlbumService>();
        }

        [OneTimeSetUp]
        public void LoadDep()
        {
            context = AutofacContainer.Resolve<IInnRoadTestDbContext>();
            LoadSeedData(context);
        }
        [OneTimeTearDown]
        public void CleanUp()
        {
            context.Dispose();
            AutofacContainer.Dispose();
        }

    }
}
