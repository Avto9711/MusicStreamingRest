using InnRoadTest.Core.Shared;
using InnRoadTest.Core.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnRoadTest.Core.Base
{
    public interface IBaseRepository<T> where T : IBaseEntity
    {
        public Task<T> GetByIdAsync(int id);
        public Task<IList<T>> ListAsync();
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(T entity);
        public Task<IList<T>> ListAsync(ISpecification<T> spec);
        public IQueryable<T> SpecAsQueryable(ISpecification<T> spec);


    }
}
