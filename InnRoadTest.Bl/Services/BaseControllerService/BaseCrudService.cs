using AutoMapper;
using InnRoadTest.Bl.Services.GetEntities;
using InnRoadTest.Core.Base;
using InnRoadTest.Core.Shared;
using InnRoadTest.Core.Specification;
using InnRoadTest.Model.Context.InnRoadTest;
using InnRoadTest.Model.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InnRoadTest.Bl.Services.BaseControllerService
{
    public class BaseCrudService<TEntity, TDto> : IBaseCrudService<TEntity, TDto>
    where TEntity : class, IBaseEntity
    where TDto : class, IBaseDto
    {
        public IMapper Mapper { get; set; }
        protected readonly IUnitOfWork<IInnRoadTestDbContext> _uow;
        protected readonly IBaseRepository<TEntity> _repository;
        public BaseCrudService(IMapper mapper, IUnitOfWork<IInnRoadTestDbContext> uow)
        {
            Mapper = mapper;
            _uow = uow;
            _repository = _uow.GetRepository<TEntity>();

        }

        public async Task<IList<TDto>> GetEntities()
        {
            var list = await _repository.ListAsync();
            var dto = Mapper.Map<IList<TDto>>(list);
            return dto;
        }

        public async Task<IList<TDto>> GetEntities(ISpecification<TEntity> spec)
        {
            var list =  await _repository.ListAsync(spec);
            var dto = Mapper.Map<IList<TDto>>(list);
            return dto;
        }

        public async Task<TDto> GetById(int id)
        {
            TEntity entity = await _repository.GetByIdAsync(id);

            if (entity is null)
                return null;

            TEntity result = await Task.FromResult(entity);

            TDto dto = Mapper.Map<TDto>(result);

            return dto;
        }

        public async Task<TDto> CreateEntity(TDto entityDto)
        {
            TEntity entity = Mapper.Map<TEntity>(entityDto);

            _repository.Add(entity);
            await _uow.Commit();

            entityDto = Mapper.Map<TDto>(entity);

            return  entityDto;
        }

        public async Task<TDto> UpdateEntity(int id,TDto entityDto)
        {
            if (entityDto.Id != id)
                return null;

            TEntity entity = await _repository.GetByIdAsync(id);
            if (entity is null)
                return null;

            Mapper.Map(entityDto, entity);

            _repository.Update(entity);

            await _uow.Commit();

            return Mapper.Map(entity, entityDto);
        }

        public async Task<TDto> DeleteEntity(int id)
        {
            TEntity entity = await _repository.GetByIdAsync(id);

            if (entity is null)
                return null;

            _repository.Delete(entity);
            await _uow.Commit();

            TDto entityDto = Mapper.Map<TDto>(entity);

            return  entityDto;
        }

        public async Task<IList<TDto>> GetEntities(params Expression<Func<TEntity, object>>[] includes)
        {
            var spec = new BaseSpecification<TEntity>();
            for (int i = 0; i < includes.Length; i++)
            {
                var include = includes[i];
                spec.AddInclude(include);
            }
            var list = await _repository.ListAsync(spec);

            var dto = Mapper.Map<IList<TDto>>(list);
            return dto;
        }

        public async Task<TDto> GetById(int id, params Expression<Func<TEntity, object>>[] includes)
        {
            var spec = new BaseSpecification<TEntity>(x=>x.Id == id);
            for (int i = 0; i < includes.Length; i++)
            {
                var include = includes[i];
                spec.AddInclude(include);
            }

            var list = await _repository.ListAsync(spec);

            var entity = list.FirstOrDefault();

            var dto = Mapper.Map<TDto>(entity);

            return dto;
        }
    }
}
