using InnRoadTest.Core.Base;
using InnRoadTest.Core.Shared;
using InnRoadTest.Model.Base;
using InnRoadTest.Model.Context;
using InnRoadTest.Model.Context.InnRoadTest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InnRoadTest.Model.UnitOfWork.InnRoadTest
{
    public class InnRoadTestUnitOfWork : IUnitOfWork<IInnRoadTestDbContext>
    {
        public IInnRoadTestDbContext context {get;set;}
        public readonly IServiceProvider _serviceProvider;


        public InnRoadTestUnitOfWork(IServiceProvider serviceProvider, IInnRoadTestDbContext context)
        {
            _serviceProvider = serviceProvider;
            this.context = context;
        }
        public async Task<int> Commit()
        {
            var result = await context.SaveChangesAsync();
            return result;
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IBaseRepository<TEntity> GetRepository<TEntity>() where TEntity : class, IBaseEntity 
        {
            return (_serviceProvider.GetService(typeof(TEntity)) ?? new BaseRepository<TEntity>(this)) as IBaseRepository<TEntity>;
        }
    }
}
