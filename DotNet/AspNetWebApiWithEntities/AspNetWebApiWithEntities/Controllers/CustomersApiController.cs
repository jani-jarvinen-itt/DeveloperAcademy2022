using AspNetWebApiWithEntities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetWebApiWithEntities.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomersApiController : ControllerBase
    {
        /*
        public string SayHello()
        {
            return "Hello, from ASP.NET Web API!";
        }

        public string SayHello2() => "Hello, from ASP.NET Web API!";
        */

        // R = read
        [HttpGet]
        [Route("")]
        public List<Customer> GetAll()
        {
            NorthwindContext context = new();
            return context.Customers.ToList();
        }

        // C = create
        [HttpPost]
        [Route("")]
        public bool AddNew(Customer customer)
        {
            NorthwindContext context = new();
            context.Customers.Add(customer);
            context.SaveChanges();

            return true;
        }

        // U = update
        [HttpPut]
        [Route("")]
        public bool UpdateExisting(Customer customer)
        {
            NorthwindContext context = new();

            // search for an existing customer
            string customerId = customer.CustomerId;
            Customer? existingCustomer =
                context.Customers.FirstOrDefault(c => c.CustomerId == customerId);
            if (existingCustomer is null)
            {
                throw new Exception("Customer id was not found.");
            }

            // update customer fields
            existingCustomer.CompanyName = customer.CompanyName;
            existingCustomer.ContactName = customer.ContactName;
            existingCustomer.ContactTitle = customer.ContactTitle;

            // save to database
            context.SaveChanges();
            return true;
        }

        // D = delete
        [HttpDelete]
        [Route("{customerId}")]
        public bool DeleteExisting(string customerId)
        {
            NorthwindContext context = new();

            // search for an existing customer
            Customer? existingCustomer =
                context.Customers.FirstOrDefault(c => c.CustomerId == customerId);
            if (existingCustomer is null)
            {
                throw new Exception("Customer id was not found.");
            }

            // delete the customer
            context.Customers.Remove(existingCustomer);

            // save to database
            context.SaveChanges();
            return true;
        }
    }
}
