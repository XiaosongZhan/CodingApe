using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodingApe.Models;

namespace CodingApe.Controllers
{
    public class ClassController : Controller
    {
        private ApplicationDbContext _context;
        public ClassController(){
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Class
        public ActionResult Class()
        {
            var user = _context.Classes.ToList();
            
            return View(user);
        }
    }
}