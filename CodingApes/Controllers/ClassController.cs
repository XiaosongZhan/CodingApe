using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodingApes.Models;
using System.Data.Entity;


namespace CodingApes.Controllers
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
            var classList = _context.Topics.Include(c => c.Section).ToList();
            return View(classList);
        }
    }
}