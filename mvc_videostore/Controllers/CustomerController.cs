using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_videostore.Models;

namespace mvc_videostore.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            return View(GetCustomers());
        }

        public ActionResult Details(int Id)
        {
            var cust = GetCustomers().SingleOrDefault(c => c.Id == Id);

            if(cust == null)
            {
                return HttpNotFound();
            }

            return View(cust);

        }

        private IEnumerable<Customer> GetCustomers()
        {
            IEnumerable<Customer> customers = new List<Customer>
            {
                new Customer {Id = 1, Name = "Alice"},
                new Customer {Id = 2, Name = "Bob"}
            };

            return customers;
        }
    }
}