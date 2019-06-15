using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;
using Vidly.ViewModels;


namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;
        public CustomerController() {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customer
        public ActionResult Custom()
        {
            var cus = _context.Customers.Include(c => c.Membership).ToList();
            return View(cus);
        }

        public ActionResult New() {
            var membership = _context.Memberships.ToList();
            var ViewModel = new NewCustomerViewModel
            {
                Memberships = membership
            };
            return View(ViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer) {
            if (!ModelState.IsValid) {
                var viewModel = new NewCustomerViewModel
                {
                    Customer = customer,
                    Memberships = _context.Memberships.ToList()
                };
                return View("New", viewModel);
            }
            if (customer.Id == 0)
            {
                _context.Customers.Add(customer);
            }
            else {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.IsSubscribed = customer.IsSubscribed;
                customerInDb.MemberId = customer.MemberId;
            }
            _context.SaveChanges();
            return RedirectToAction("Custom", "Customer");
        }
    }
}