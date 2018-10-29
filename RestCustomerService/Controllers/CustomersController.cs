using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelClassCustomer.model;

namespace RestCustomerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private static List<Customer> cList = new List<Customer>()
        {
            new Customer(){Id = 1234, FirstName = "Jens", LastName = "Jensen", YearOfreg = 1988},
            new Customer(){Id = 7895, FirstName = "Tyga", LastName = "Tasten", YearOfreg = 1999},
            new Customer(){Id = 5555, FirstName = "Stuart",LastName = "Stardust", YearOfreg = 2000}
        };

        // GET: api/Customers
        [HttpGet]
        //[Route("api/Customers")]
        public IEnumerable<Customer> GetAll()
        {
            return cList;
        }

        //GET: api/Customers/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Customers
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT: api/Customers/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        public void Start()
        {
            
        }
    }
}
