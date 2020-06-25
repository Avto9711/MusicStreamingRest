using Autofac;
using AutoMapper;
using InnRoadTest.Bl.Mapper;

namespace InnRoadTest.Bl.Ioc
{
    //public static class Registry
    //{
    //    public static void AddBlRegistry(this IServiceCollection services)
    //    {
    //        services.AddAutoMapper(typeof(InnRoadTestProfile));
    //    }
    //}

    public class BlModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(cfg => new MapperConfiguration(cfg => cfg.AddProfile(typeof(InnRoadTestProfile))));
            builder.Register(ctx=> ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();
        }
    }
}
