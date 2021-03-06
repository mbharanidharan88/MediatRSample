using MediatR;
using MediatRSample.Core.Commands;
using MediatRSample.Core.Queries;
using MediatRSample.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MediatRSample.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        public async Task<IEnumerable<EmployeeEntity>> Get()
        {
            return await _mediator.Send(new GetEmployeeListQuery());
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public async Task<EmployeeEntity> Get(Guid id)
        {
            return await _mediator.Send(new GetEmployeeByIdQuery(id));
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public async Task<EmployeeEntity> Post([FromBody] EmployeeEntity employee)
        {
            return await _mediator.Send(new CreateEmployeeCommand(employee.FirstName, employee.LastName));
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
