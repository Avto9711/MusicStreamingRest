using InnRoadTest.Core.Base;
using InnRoadTest.Core.Shared;
using InnRoadTest.Model.Context.InnRoadTest;
using InnRoadTest.Model.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

        public async Task<List<T>> ListAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
