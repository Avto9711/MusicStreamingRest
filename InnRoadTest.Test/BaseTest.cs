using Autofac;
using InnRoadTest.Bl.Ioc;
using InnRoadTest.Model.Ioc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using InnRoadTest.Model.Context;
using Autofac.Extensions.DependencyInjection;
using InnRoadTest.Model.Context.InnRoadTest;
using InnRoadTest.Model.Models;
using InnRoadTest.Model.Seed;

namespace InnRoadTest.Test
{
    //https://github.com/autofac/Examples/issues/1 & 
    public class BaseTest
    {
        private IContainer _autofacContainer;
        protected IContainer AutofacContainer
        {
            get
            {
                if (_autofacContainer == null)
                {
                    var builder = new ContainerBuilder();

                    IServiceCollection services = new ServiceCollection();
                    services.AddDbContext<InnRoadTestDbContext>(opt => opt.UseInMemoryDatabase(databaseName: "InMemoryDb"),
                                                       ServiceLifetime.Scoped,
                                                       ServiceLifetime.Scoped);

                    builder.Populate(services);
                    builder.RegisterModule(new BlModule());
                    builder.RegisterModule(new ModelModule());

                    var container = builder.Build();

                    _autofacContainer = container;
                }

                return _autofacContainer;
            }
        }

        public  void LoadSeedData(IInnRoadTestDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

        }
    }
}
