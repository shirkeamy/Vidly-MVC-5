using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_MVC.Models;

namespace Vidly_MVC.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            var customers = new List<Customer>{
                new Customer{ Id=1,Name="Sudam Shirke"},
                new Customer{ Id=2,Name="Sanjivani Shirke"},
                new Customer{ Id=3,Name="Kiran Shirke"},
                new Customer{ Id=4,Name="Ashwini Shirke"},
                new Customer{ Id=5,Name="Amol Shirke"},
                new Customer{ Id=6,Name="Komal Shirke"},
            };
            return customers;
        }
    }
}