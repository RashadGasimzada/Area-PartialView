using FrontToBack.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        public SliderController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var sliders = await _context.Sliders.Where(m => m.IsDeleted == false).ToListAsync();
            return View(sliders);
        }
        public IActionResult Detail(int id)
        {
            var slider = _context.Sliders.Where(m => !m.IsDeleted).FirstOrDefault(m=>m.Id == id);
            return View(slider);
        }
        public IActionResult Edit(int id)
        {
            return Json(new
            {
                action = "Edit",
                Id = id,
            });
        }
        public IActionResult Delete(int id)
        {
            return Json(new
            {
                action = "Delete",
                Id = id,
            });
        }
    }
}
