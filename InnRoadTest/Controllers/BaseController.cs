using AutoMapper;
using InnRoadTest.Core.Base;
using InnRoadTest.Core.Shared;
using InnRoadTest.Model.Context.InnRoadTest;
using InnRoadTest.Model.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InnRoadTest.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public abstract class BaseController<TEntity, TDto>: ControllerBase 
        where TEntity :  class, IBaseEntity
        where TDto : class, IBaseDto
    {
        public IMapper Mapper { get; set; }
        protected readonly IUnitOfWork<IInnRoadTestDbContext> _uow;
        protected readonly IBaseRepository<TEntity> _repository;


        public BaseController(IMapper mapper, IUnitOfWork<IInnRoadTestDbContext> uow)
        {
             Mapper = mapper;
            _uow = uow;
            _repository = _uow.GetRepository<TEntity>();

        }

        /// <summary>
        /// Get all by query options.
        /// </summary>
        /// <returns>A list of records.</returns>
        [HttpGet]
        public async virtual Task<IActionResult> Get()
        {
            var list = await _repository.ListAsync();
            var dto =  Mapper.Map<IList<TDto>>(list);
            return Ok(dto);
        }


        /// <summary>
        /// Get a specific record by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A specific record.</returns>
        [HttpGet("{id}")]
        public async virtual Task<IActionResult> GetById(int id)
        {
            TEntity entity = await _repository.GetByIdAsync(id);

            if (entity is null)
                return NotFound();

            TEntity result = await Task.FromResult(entity);

            TDto dto = Mapper.Map<TDto>(result);

            return Ok(dto);
        }

        /// <summary>
        /// Creates a record.
        /// </summary>
        /// <returns>A newly created record.</returns>
        [HttpPost]
        public virtual async Task<IActionResult> Post([FromBody] TDto entityDto)
        {
            TEntity entity = Mapper.Map<TEntity>(entityDto);

            _repository.Add(entity);
            await _uow.Commit();

            entityDto = Mapper.Map<TDto>(entity);

            return Created(this.ControllerContext.HttpContext.Request.Host.Value,entityDto);
        }

        /// <summary>
        /// Updates a record.
        /// </summary>
        /// <returns>No Content.</returns>
        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Put([FromRoute]int id, [FromBody] TDto entityDto)
        {
            if (entityDto.Id != id)
                return BadRequest();

            TEntity entity = await _repository.GetByIdAsync(id);
            if (entity is null)
                return NotFound();

            Mapper.Map(entityDto, entity);

            _repository.Update(entity);

            await _uow.Commit();

            return Ok(Mapper.Map(entity, entityDto));
        }

        /// <summary>
        /// Deletes a specific record by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A deleted record.</returns>
        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(int id)
        {
            TEntity entity = await _repository.GetByIdAsync(id);

            if (entity is null)
                return NotFound();

            _repository.Delete(entity);
            await _uow.Commit();

            TDto entityDto = Mapper.Map<TDto>(entity);

            return Ok(entityDto);
        }
    }
}
