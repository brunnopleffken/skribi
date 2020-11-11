using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Skribi.Models;
using Skribi.ViewModels;

namespace Skribi.Controllers
{
    public class RoomsController : ApplicationController
    {
        public RoomsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int id)
        {
            RoomViewModel model = new RoomViewModel
            {
                Room = await _context.Rooms.FindAsync(id),

                Threads = await _context.Threads
                    .Include(t => t.User)
                    .Where(t => t.RoomId == id)
                    .OrderByDescending(t => t.CreatedAt)
                    .ToListAsync()
            };

            return View(model);
        }
    }
}
