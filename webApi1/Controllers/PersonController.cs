using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDD1.Domain.Entities;
using DDD1.Infraestructure.InputPort;
using Microsoft.AspNetCore.Mvc;

namespace Namespace
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonUseCaseServices personUseCaseServices;
        public PersonController(IPersonUseCaseServices _personUseCaseServices)
        {
            personUseCaseServices = _personUseCaseServices;
        }

        [HttpGet]
        public async Task<IEnumerable<Person>> Get()
        {
            return await personUseCaseServices.getAllPerson();
        }

        [HttpGet("{id}")]
        public async Task<Person> Get(int id)
        {
            var result = await personUseCaseServices.getPersonById(id);
            return result;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Person value)
        {
            var response = await personUseCaseServices.createPerson(value.Nombre, value.Edad, value.Sexo);

            if(response > 0)
                return Ok();
            else
                return NotFound();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}