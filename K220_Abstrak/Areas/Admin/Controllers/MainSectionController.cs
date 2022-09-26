using K220_Abstrak.DataAccess.Context;
using K220_Abstrak.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace K220_Abstrak.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    public class MainSectionController : Controller
    {
        private readonly AppDbContext _context;

        public MainSectionController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _context.MainSections
                .Where(e => !e.IsDeleted)
                .AsQueryable()
                .OrderByDescending(e => e.Id)
                .ToListAsync();
            return View(data);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(MainSection data)
        {
            data.CreatedAt = DateTime.UtcNow;
            _context.MainSections.Add(data);
            await _context.SaveChangesAsync();
            return View();
        }
    }
}
