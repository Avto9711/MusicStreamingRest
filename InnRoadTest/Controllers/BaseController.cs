using AutoMapper;
using InnRoadTest.Bl.Services.GetEntities;
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
        protected readonly IBaseCrudService<TEntity, TDto> BaseControllerService;


        public BaseController(IBaseCrudService<TEntity, TDto> baseControllerService)
        {
            BaseControllerService = baseControllerService;
        }

        /// <summary>
        /// Get all by query options.
        /// </summary>
        /// <returns>A list of records.</returns>
        [HttpGet]
        public async virtual Task<IActionResult> Get()
        {
            var dto = await BaseControllerService.GetEntities();
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
            TDto dto = await BaseControllerService.GetById(id);
            if (dto is null)
                return NotFound();

            return Ok(dto);
        }

        /// <summary>
        /// Creates a record.
        /// </summary>
        /// <returns>A newly created record.</returns>
        [HttpPost]
        public virtual async Task<IActionResult> Post([FromBody] TDto entityDto)
        {
            entityDto = await BaseControllerService.CreateEntity(entityDto);

            return Created(this.ControllerContext.HttpContext.Request.Host.Value,entityDto);
        }

        /// <summary>
        /// Updates a record.
        /// </summary>
        /// <returns>No Content.</returns>
        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Put([FromRoute]int id, [FromBody] TDto entityDto)
        {
            TDto response = await BaseControllerService.UpdateEntity(id, entityDto);
            if (response is null)
                return BadRequest();

            return Ok(response);
        }

        /// <summary>
        /// Deletes a specific record by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A deleted record.</returns>
        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(int id)
        {
            TDto entityDto = await BaseControllerService.DeleteEntity(id);

            if (entityDto is null)
                return NotFound();
            return Ok(entityDto);
        }
    }
}
