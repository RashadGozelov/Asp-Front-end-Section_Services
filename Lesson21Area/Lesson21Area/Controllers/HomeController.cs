using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson21Area.DAL;
using Lesson21Area.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Lesson21Area.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeModel homeModel = new HomeModel
            {
                Sliders = _context.Sliders,
                Descriptions = _context.Descriptions,
                Welcomes=_context.Welcomes,
                WhatWeDos=_context.WhatWeDos,
                Servicess=_context.Servicess
            };
            return View(homeModel);
            
        }
    }
}