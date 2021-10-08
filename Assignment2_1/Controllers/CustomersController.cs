using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Assignment2_1.Models;
namespace Assignment2_1.Controllers
{
    public class CustomersController : Controller
    {
        static List<Customer> Cust = new List<Customer>
        {
            new Customer(){CustomerId=1,Name="Vinu",Phone_No=8999,Email="g.vinu@h",City="Pune" }
        };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View(Cust);
        }
        public IActionResult Details(int id)
        {
            var Check_Customer = Cust.Find(obj => obj.CustomerId == id);
            if(Check_Customer== null)
            {
                return View("Not Found");
            }
            return View(Check_Customer);
        }

        [HttpPost]
        public IActionResult Create(Customer Cust_1)
        {
            
            if (!ModelState.IsValid)
         {
                ViewBag.Error = "Please Correct Validation";
                return View(Cust_1);
            }
         Cust.Add(Cust_1);
        return RedirectToAction("Index");
        }

       
        public IActionResult Create()
        {
          return View();
        }
    }
}
