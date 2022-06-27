using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedaLab_Back_End.DAL;
using MedaLab_Back_End.Models;
using MedaLab_Back_End.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MedaLab_Back_End.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Card> cards = await _context.Cards.ToListAsync();
            List<Gallery> galleries = await _context.Galleries.ToListAsync();
            List<Doctor> doctors = await _context.Doctors.ToListAsync();
            List<ServiceCard> serviceCards = await _context.Services.ToListAsync();
            List<Profession> professions = await _context.Professions.ToListAsync();
            List<Address> addresses = await _context.Addresses.ToListAsync();

            HomeVM model = new HomeVM
            {
                Cards = cards,
                Galleries = galleries,
                Doctors = doctors,
                Services = serviceCards,
                Professions = professions,
                Addresses = addresses
            };
            return View(model);
        }
    }
}
