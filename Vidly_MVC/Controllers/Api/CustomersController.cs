using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly_MVC.Models;

namespace Vidly_MVC.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/customers
        public IHttpActionResult GetCustomers()
        {
            var customers = _context.Customers.ToList();

            return Ok(customers);
        }

        //GET /api/customer/1
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c=>c.Id==id);

            if (customer == null)
                return NotFound();

            return Ok(customer);
        }

        // POST /api/customers
        [HttpPost]
        public IHttpActionResult CreateCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _context.Customers.Add(customer);
            _context.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/"+customer.Id),customer);
        }

        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id,Customer customer)
        {

            if (!ModelState.IsValid)
                return BadRequest();

            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
                return NotFound();

            customerInDb.Name = customer.Name;
            customerInDb.DateOfBirth = customer.DateOfBirth;
            customerInDb.MembershipTypeId = customer.MembershipTypeId;
            customerInDb.IsSubscribeToNewLeter = customer.IsSubscribeToNewLeter;

            _context.SaveChanges();

            return Ok(customer);
        }

        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
                return NotFound();

            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();

            return Ok(customerInDb);

        }

    }
}
