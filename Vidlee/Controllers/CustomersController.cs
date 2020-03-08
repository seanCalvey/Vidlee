using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidlee.Models;

namespace Vidlee.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {

            var customers = GetCustomers();
            return View(customers);
        }

        private List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {Id = 1, Name = "John Smith"},
                 new Customer {Id = 2, Name = "Mary William"}
            };
        }
    }
}