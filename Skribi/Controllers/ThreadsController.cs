using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Skribi.Models;
using Skribi.ViewModels;

namespace Skribi.Controllers
{
    public class ThreadsController : ApplicationController
    {
        public ThreadsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int id)
        {
            ThreadViewModel model = new ThreadViewModel
            {
                Thread = await _context.Threads
                    .Include(t => t.User)
                    .Include(t => t.Room)
                    .SingleAsync(t => t.Id == id),

                Replies = await _context.Replies
                    .Where(r => r.ThreadId == id)
                    .Include(r => r.User)
                    .ToListAsync()
            };

            return View(model);
        }
    }
}
