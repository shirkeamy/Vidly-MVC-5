using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using Vidly_MVC.Models;
using Vidly_MVC.ViewModels;

namespace Vidly_MVC.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c=>c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();
            else
                return View(customer);
        }

        public ActionResult New()
        {
            var membershipType = _context.MembershipTypes.ToList();
            var viewModel = new CustometFormViewModel
            {
                MembershipTypes=membershipType,
                Customer=new Customer()
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CustometFormViewModel
                {
                    Customer=customer,
                    MembershipTypes=_context.MembershipTypes.ToList()
                };
                return View("New",viewModel);
            }
            if (customer.Id==0)
            {
                _context.Customers.Add(customer);
            }
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.DateOfBirth = customer.DateOfBirth;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribeToNewLeter = customer.IsSubscribeToNewLeter;
            }
            _context.SaveChanges();
            return RedirectToAction("Index","Customers");
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id==id);
            if (customer == null)
                return HttpNotFound();
            
            var viewModel = new CustometFormViewModel
            {
                MembershipTypes = _context.MembershipTypes.ToList(),
                Customer = customer
            };
            return View("New", viewModel);
        }

    }
}