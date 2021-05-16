using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tao123.Models;

namespace tao123.Controllers
{
    public class CustomerController : Controller
    {

        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customer
        public ActionResult Index()
        {

            Customer customer = new Customer { Name = "Ali" };

            _context.Customers.Add(customer);
            _context.SaveChanges();

            return View(customer);
        }

       
    }
}