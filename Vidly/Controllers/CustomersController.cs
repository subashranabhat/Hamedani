using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new Customer();
            customers.Name = "dari";
            return View(customers);
        }

        public ActionResult NameList()
        {
            var items = new List<Customer>()
            {
                new Customer() {Name="John" },
                new Customer() {Name="Burris" }

            };

            return View(items);
        }



        public ActionResult Details(int index)
        {

            return View();
        }
    }
}