using Autofac;
using InnRoadTest.Model.Context;
using InnRoadTest.Model.Context.InnRoadTest;
using InnRoadTest.Model.UnitOfWork;
using InnRoadTest.Model.UnitOfWork.InnRoadTest;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnRoadTest.Model.Ioc
{
    //public static class  Registry
    //{
    //    public static void AddModelRegistry(this IServiceCollection services)
    //    {
    //        services.AddTransient<IInnRoadTestDbContext, InnRoadTestDbContext>();
    //        services.AddScoped<IUnitOfWork<IInnRoadTestDbContext>, InnRoadTestUnitOfWork>();
    //    }
    //}

    public class ModelModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<InnRoadTestDbContext>().As<IInnRoadTestDbContext>().InstancePerLifetimeScope();
            builder.RegisterType<InnRoadTestUnitOfWork>().As<IUnitOfWork<IInnRoadTestDbContext>>().InstancePerLifetimeScope();
            //base.Load(builder);
        }
    }
}
