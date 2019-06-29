using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;
using System.Data.Entity;

namespace WebApplication.Controllers
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
        public ActionResult Customer()
        {
            var cus = _context.Customers.Include(c => c.Membership).ToList();
            return View(cus);
        }
    }
}