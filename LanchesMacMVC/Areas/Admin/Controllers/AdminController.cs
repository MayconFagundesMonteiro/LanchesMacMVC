using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMacMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
