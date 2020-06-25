using InnRoadTest.Core.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InnRoadTest.Core.Base
{
    public interface IBaseRepository<T> where T : IBaseEntity
    {
        public Task<T> GetByIdAsync(int id) ;
        public Task<List<T>> ListAsync() ;
        public void Add(T entity) ;
        public void Update(T entity) ;
        public void Delete(T entity) ;
    }
}
