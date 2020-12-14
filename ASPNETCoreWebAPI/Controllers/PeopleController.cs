using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreWebAPI.Controllers
{
    [ApiController]
    [Route("people")]
    public class PeopleController : ControllerBase
    {
        List<Person> people = new List<Person>();
        
        [HttpGet]
        public async Task<IEnumerable<Person>> Get()
        {
            return await Task.Run(() => LoadPeople());
        }

        [HttpPost("CreatePerson")]
        public async Task<ActionResult<Person>> Post(Person person)
        {
            return await Task.Run(() => CreatedAtAction($"getperson/{1}", new Person()));
        }

        [HttpPut("UpdatePerson")]
        public async Task<ActionResult<Person>> Update(Person person)
        {
            return await Task.Run(() => CreatedAtAction($"getperson/{1}", new Person()));
        }

        [HttpGet("getperson/{id}")]
        public async Task<ActionResult<Person>> GetPerson(int id)
        {
            return await Task.FromResult(LoadPeople().Where(p => p.Id == id).FirstOrDefault());
        }

        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Person>> DeletePerson(int id)
        {
            LoadPeople();
            people.Remove(people.Where(p => p.Id == id).FirstOrDefault());
            return people;
        }

        private List<Person> LoadPeople()
        {
            people.Add(new Person()
            {
                Id = 1,
                FirstName = "Fahad",
                LastName = "Mullaji",
                DateOfBirth = Convert.ToDateTime("12/08/1988"),
                Salary = 90000
            });
            people.Add(new Person()
            {
                Id = 2,
                FirstName = "Monica",
                LastName = "Mullaji",
                DateOfBirth = Convert.ToDateTime("04/12/1990"),
                Salary = 90000
            });
            people.Add(new Person()
            {
                Id = 3,
                FirstName = "Erin",
                LastName = "Carr",
                DateOfBirth = Convert.ToDateTime("12/08/1988"),
                Salary = 45000
            });
            people.Add(new Person()
            {
                Id = 4,
                FirstName = "Joe",
                LastName = "Fogiato",
                DateOfBirth = Convert.ToDateTime("12/08/1988"),
                Salary = 90000
            });

            return people;
        }
    }
}
