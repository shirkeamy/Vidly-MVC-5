using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            IEnumerable<Customer> customers = new List<Customer>
            {
                 new Customer{ Id=1,Name="Arjun"},
                new Customer{ Id=2,Name="Karn"},
                new Customer{ Id=3,Name="Krishna"},
                new Customer{ Id=4,Name="Bhishma"},
                new Customer{ Id=5,Name="Bhim"},
                new Customer{ Id=6,Name="Nakul"},
                new Customer{ Id=7,Name="Sahadev"},
                new Customer{ Id=8,Name="Yudhisthir"},
            };
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            IEnumerable<Customer> customers = new List<Customer>
            {
                 new Customer{ Id=1,Name="Arjun"},
                new Customer{ Id=2,Name="Karn"},
                new Customer{ Id=3,Name="Krishna"},
                new Customer{ Id=4,Name="Bhishma"},
                new Customer{ Id=5,Name="Bhim"},
                new Customer{ Id=6,Name="Nakul"},
                new Customer{ Id=7,Name="Sahadev"},
                new Customer{ Id=8,Name="Yudhisthir"},
            };

            var customer = customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();
            else
                return View(customer);
        }

    }
}