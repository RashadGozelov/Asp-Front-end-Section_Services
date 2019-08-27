using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson21Area.DAL;
using Microsoft.AspNetCore.Mvc;
using Lesson21Area.Models;

namespace Lesson21Area.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ServicesController : Controller
    {
        private AppDbContext _context;
        public ServicesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Servicess);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Services skill = await _context.Servicess.FindAsync(id);
            if (skill == null) return NotFound();
            return View(skill);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Services skilll)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await _context.Servicess.AddAsync(skilll);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
            //return Content($"title-{skilll.Title} description-{skilll.Description}");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Services skill = await _context.Servicess.FindAsync(id);
            if (skill == null) return NotFound();
            return View(skill);
        }
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            Services skill = await _context.Servicess.FindAsync(id);
            _context.Servicess.Remove(skill);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}