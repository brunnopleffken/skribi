using System;
using Microsoft.AspNetCore.Mvc;
using Skribi.Models;

namespace Skribi.Controllers
{
    public class ApplicationController : Controller
    {
        protected ApplicationDbContext _context;
    }
}
