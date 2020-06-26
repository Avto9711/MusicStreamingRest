using InnRoadTest.Core.Shared;
using InnRoadTest.Core.Specification;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InnRoadTest.Bl.Services.GetEntities
{
    public interface IBaseControllerService<TEntity, TDto>
        where TEntity : class, IBaseEntity
        where TDto : class, IBaseDto
    {
        Task<IList<TDto>> GetEntities();
        Task<IList<TDto>> GetEntities(ISpecification<TEntity>  spec);
        Task<IList<TDto>> GetEntities(params Expression<Func<TEntity, object>>[] includes);
        Task<TDto> GetById(int id);
        Task<TDto> GetById(int id, params Expression<Func<TEntity, object>>[] includes);
        Task<TDto> CreateEntity(TDto entity);
        Task<TDto> UpdateEntity(int id, TDto entity);
        Task<TDto> DeleteEntity(int id);
    }
}
