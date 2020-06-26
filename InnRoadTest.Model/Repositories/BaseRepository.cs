using InnRoadTest.Core.Base;
using InnRoadTest.Core.Shared;
using InnRoadTest.Core.Specification;
using InnRoadTest.Model.Context.InnRoadTest;
using InnRoadTest.Model.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnRoadTest.Model.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IBaseEntity
    {
        public readonly IUnitOfWork<IInnRoadTestDbContext> _uow;
        public readonly IInnRoadTestDbContext _context;
        public readonly DbSet<T> _dbSet;
        public BaseRepository(IUnitOfWork<IInnRoadTestDbContext> uow)
        {
            _uow = uow;
            _context = _uow.context;
            _dbSet = _context.GetDbSet<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.SingleOrDefaultAsync(x=>x.Id == id);
        }

        public async Task<IList<T>> ListAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public async Task<IList<T>> ListAsync(ISpecification<T> spec)
        {
            var queryableResultWithIncludes = spec.Includes
                .Aggregate(_dbSet.AsQueryable(),
                    (current, include) => current.Include(include));

            // modify the IQueryable to include any string-based include statements
            var secondaryResult = spec.IncludeStrings
                .Aggregate(queryableResultWithIncludes,
                    (current, include) => current.Include(include));

            if (spec.Criteria != null)
                secondaryResult = secondaryResult
                            .Where(spec.Criteria).AsQueryable();

            // return the result of the query using the specification's criteria expression
            return await secondaryResult.ToListAsync();
        }

        public  IQueryable<T> SpecAsQueryable(ISpecification<T> spec)
        {
            var queryableResultWithIncludes = spec.Includes
                .Aggregate(_dbSet.AsQueryable(),
                    (current, include) => current.Include(include));

            // modify the IQueryable to include any string-based include statements
            var secondaryResult = spec.IncludeStrings
                .Aggregate(queryableResultWithIncludes,
                    (current, include) => current.Include(include));

            if (spec.Criteria != null)
                secondaryResult = secondaryResult
                            .Where(spec.Criteria).AsQueryable();

            // return the result of the query using the specification's criteria expression
            return  secondaryResult.AsQueryable();
        }

    }
}
