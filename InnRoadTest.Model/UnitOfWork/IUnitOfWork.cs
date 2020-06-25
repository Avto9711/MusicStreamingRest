using InnRoadTest.Core.Base;
using InnRoadTest.Core.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace InnRoadTest.Model.UnitOfWork
{
    public interface IUnitOfWork<TContext> : IDisposable
    {
        public IBaseRepository<TEntity> GetRepository<TEntity>() where TEntity : class, IBaseEntity;
        Task<int> Commit();
        TContext context { get; }

    }


    //public interface IUnitOfWork<TContext> : IUnitOfWork
    //{
    //}
}
