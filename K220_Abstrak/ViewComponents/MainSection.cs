using K220_Abstrak.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace K220_Abstrak.ViewComponents
{
    public class MainSection : ViewComponent
    {
        private readonly AppDbContext _context;

        public MainSection(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await _context.MainSections
                .Where(e => !e.IsDeleted)
                .OrderByDescending(e => e.Id)
                .AsQueryable()
                .FirstOrDefaultAsync();
            return View(data);
        }
    }
}
