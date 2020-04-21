using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Retroly.Models;
using Retroly.ViewModels;

namespace Retroly.Controllers
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

        public ActionResult New()
        {
            var MembershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel()
            {
                MembershipTypes = MembershipTypes
            };
            return View(viewModel);
        }


            // GET: Customer
            public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);
        }

        //GET: Customer/Details
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return Content("Customer ID not found");
            }
            return View(_context.Customers.Include(c => c.MembershipType).SingleOrDefault(customer => customer.Id == id));
        }
    }
}