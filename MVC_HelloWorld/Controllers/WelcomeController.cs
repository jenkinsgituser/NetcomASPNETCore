﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC_HelloWorld.Controllers
{
    
    public class WelcomeController : Controller
    {
       
        
        public IActionResult Index()
        {
            
            return View();

            
        }

       
        public IActionResult Login()
        {
            return View();
            
        }


        public IActionResult Layout()
        {
            return View();
        }
    }
}