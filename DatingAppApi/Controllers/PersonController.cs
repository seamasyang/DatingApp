using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using DatingAppApi.Models;

namespace DatingAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return PersonRepository.ListPerson();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Person Get(int id) => PersonRepository.GetPerson(id);

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Person person)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Person person)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
        }
    }
}
