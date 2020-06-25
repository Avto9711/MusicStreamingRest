using InnRoadTest.Core.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnRoadTest.Bl.Services.GetEntities
{
    public interface IBaseControllerService<TEntity, TDto>
        where TEntity : class, IBaseEntity
        where TDto : class, IBaseDto
    {
        IList<TDto> GetEntities();
        IList<TDto> GetEntities(ISpecification<TEntity>  spec);
    }
}
