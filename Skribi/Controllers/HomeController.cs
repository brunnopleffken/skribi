using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Skribi.Models;
using Skribi.ViewModels;

namespace Skribi.Controllers
{
    public class HomeController : ApplicationController
    {
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            HomeViewModel model = new HomeViewModel
            {
                Rooms = await _context.Rooms.ToListAsync()
            };

            return View(model);
        }
    }
}
