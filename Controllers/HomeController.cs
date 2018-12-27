using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UsingInject.Services;

namespace UsingInject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           CustomersServices cs = new CustomersServices();
            var allCS = cs.GetAllCustomersData();
            return View(allCS);
        }
    }
}
