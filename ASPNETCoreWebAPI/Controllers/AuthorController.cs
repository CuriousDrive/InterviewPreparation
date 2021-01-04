using ASPNETCoreWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPNETCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly BookStoresDBContext _bookStoresDBContext;

        public AuthorController(BookStoresDBContext bookStoresDBContext)
        {
            _bookStoresDBContext = bookStoresDBContext;
        }

        // GET: api/<Controller>
        [HttpGet]
        public async Task<IEnumerable<Author>> Get()
        {
            var authors = await _bookStoresDBContext.Authors
                                                    .Include(a => a.BookAuthors)
                                                    .ToListAsync();
            return authors;
        }

        // GET api/<Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
