using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Skribi.Models;

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
            Room room = await _context.Rooms.FindAsync(id);
            List<Thread> threads = await _context.Threads.Include(thread => thread.User).ToListAsync();

            ViewData["RoomName"] = room.Title;

            return View(threads);
        }
    }
}
