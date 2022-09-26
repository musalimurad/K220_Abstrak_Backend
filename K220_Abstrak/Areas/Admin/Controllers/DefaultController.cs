using Microsoft.AspNetCore.Mvc;

namespace K220_Abstrak.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
