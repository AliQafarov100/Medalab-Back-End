using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedaLab_Back_End.DAL;
using MedaLab_Back_End.Extensions;
using MedaLab_Back_End.Models;
using MedaLab_Back_End.Utilities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MedaLab_Back_End.Areas.MedalabAdmin.Controllers
{
    [Area("MedalabAdmin")]
    public class GalleryController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public GalleryController(AppDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Gallery> galleries = await _context.Galleries.ToListAsync();
            return View(galleries);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Create(Gallery gallery)
        {
            if (!ModelState.IsValid) return NotFound();

            if(gallery.Photo != null)
            {
                if (gallery.Photo.IsOkay(1))
                {
                    gallery.Image = await gallery.Photo.FileCreate(_env.WebRootPath, @"assets\Image\Galerys");
                }

                _context.Galleries.Add(gallery);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError("Photo", "Please choose image file");
                return View();
            }
        }

        public async Task<IActionResult> Edit(int id)
        {
            Gallery gallery = await _context.Galleries.FirstOrDefaultAsync(g => g.Id == id);

            if (gallery == null) return NotFound();

            return View(gallery);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Edit(int id,Gallery gallery)
        {
            Gallery existed = await _context.Galleries.FindAsync(id);

            if (!ModelState.IsValid) return NotFound();

            if(gallery.Photo != null)
            {
                if (gallery.Photo.IsOkay(1))
                {
                    string path = _env.WebRootPath + @"assets\Image\Galerys" + existed.Image;

                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }

                    existed.Image = await gallery.Photo.FileCreate(_env.WebRootPath, @"assets\Image\Galerys");
                }
            }
            else
            {
                ModelState.AddModelError("Photo", "Please choose image file");
                return View();
            }
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            Gallery gallery = await _context.Galleries.FindAsync(id);

            if (gallery == null) return NotFound();

            return View(gallery);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]

        public async Task<IActionResult> DeleteImage(int id)
        {
            if (!ModelState.IsValid) return NotFound();
            Gallery existed = await _context.Galleries.FindAsync(id);

            if (existed == null) return BadRequest();

            string path = _env.WebRootPath + @"assets\Image\Galerys" + existed.Image;

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            _context.Galleries.Remove(existed);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detail(int id)
        {
            Gallery gallery = await _context.Galleries.FindAsync(id);

            if (gallery == null) return NotFound();

            return View(gallery);
        }
    }
}
