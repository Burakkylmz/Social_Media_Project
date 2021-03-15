﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SM_DomainLayer.Entities.Concrete;
using SM_InfrastuctureLayer.Context;
using SM_PresentationLayer.Models;

namespace SM_PresentationLayer.Controllers
{
    [Authorize]
    
    public class HomeController : Controller
    {
       
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,
                               ApplicationDbContext context,
                               UserManager<AppUser> userManager)
        {
            _logger = logger;
            
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
        
            return View();
           
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
