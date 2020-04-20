using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Retroly.Models;

namespace Retroly.Controllers
{
    public class CustomerController : Controller
    {

        List<Customer> customerList = new List<Customer>
        {
            new Customer {Id = 1, Name = "Joe Bloggs"},
            new Customer {Id = 2, Name = "John Smith"},
            new Customer {Id = 3, Name = "Jane Doe"}
        };

        // GET: Customer
        public ActionResult Index()
        {
            return View(customerList);
        }
    }
}