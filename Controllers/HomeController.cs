using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab3.Models;

namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Razor() => View();

        [HttpPost]
        public IActionResult Count()
        {
            
            return View();
        }

        public IActionResult CreatePerson() => View();

        [HttpPost]
        public IActionResult DisplayPerson(Person person)
        {
            return View(person);
        }
        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
