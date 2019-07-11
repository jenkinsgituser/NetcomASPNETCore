using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_HelloWorld.Models;

namespace MVC_HelloWorld.Controllers
{
    public class RegistrationController : Controller
    {
        ECommerceDbContext context;

        public RegistrationController(ECommerceDbContext con)
        {
            context = con;
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View("Registration");
        }

        [HttpPost]
        public IActionResult Create(Registration regDetails)
        {
            if(ModelState.IsValid)
            {
                
                context.RegistrationTable.Add(regDetails);
                context.SaveChanges();

                return RedirectToAction("Login");
            }
            return View("Registration",regDetails);
        }
    }
}