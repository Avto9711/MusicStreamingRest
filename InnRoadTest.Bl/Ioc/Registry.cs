using Autofac;
using AutoMapper;
using InnRoadTest.Bl.Mapper;
using InnRoadTest.Bl.Services.BaseControllerService;
using InnRoadTest.Bl.Services.GetEntities;
using InnRoadTest.Model.Repositories.SongRepository;
using System;

namespace InnRoadTest.Bl.Ioc
{
    public class BlModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(cfg => new MapperConfiguration(cfg => cfg.AddProfile(typeof(InnRoadTestProfile))));
            builder.Register(ctx=> ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();

            //https://stackoverflow.com/questions/16757945/how-to-register-many-for-open-generic-in-autofac
            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
                               .AsClosedTypesOf(typeof(IBaseCrudService<,>)).AsImplementedInterfaces();


            builder.RegisterType<SongRepository>().As<ISongRepository>().InstancePerLifetimeScope();

        }
    }
}
