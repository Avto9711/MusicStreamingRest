using InnRoadTest.Bl.Services.GetEntities;
using InnRoadTest.Core.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnRoadTest.Bl.Services.AlbumService
{
    public interface IAlbumService<TEntity, TDto> : IBaseControllerService<TEntity, TDto>
    where TEntity : class, IBaseEntity
    where TDto : class, IBaseDto
    { }
}
