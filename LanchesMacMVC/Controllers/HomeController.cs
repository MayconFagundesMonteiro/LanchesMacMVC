using LanchesMacMVC.Models.ViewModels;
using LanchesMacMVC.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMacMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public HomeController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }
        public IActionResult Index()
        {
            var homeviewModel = new HomeViewModel
            {
                LanchesPreferidos = _lancheRepository.LanchesPreferidos
            };
            return View(homeviewModel);
        }
    }
}
