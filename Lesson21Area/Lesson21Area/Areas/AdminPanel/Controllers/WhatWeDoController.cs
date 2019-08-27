using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson21Area.DAL;
using Lesson21Area.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson21Area.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class WhatWeDoController : Controller
    {
        private AppDbContext _context;
        public WhatWeDoController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.WhatWeDos);
        }
        //public IActionResult Create()
        //{
        //    return Content("salam");
        //}
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            WhatWeDo skill =await _context.WhatWeDos.FindAsync(id);
            if (skill == null) return NotFound();
            return View(skill);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(WhatWeDo skilll)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await _context.WhatWeDos.AddAsync(skilll);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
            //return Content($"title-{skilll.Title} description-{skilll.Description}");
        }
       public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            WhatWeDo skill = await _context.WhatWeDos.FindAsync(id);
            if (skill == null) return NotFound();
            return View(skill);
        }
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            WhatWeDo skill = await _context.WhatWeDos.FindAsync(id);
            _context.WhatWeDos.Remove(skill);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}