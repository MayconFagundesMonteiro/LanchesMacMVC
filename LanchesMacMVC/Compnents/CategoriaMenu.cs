using LanchesMacMVC.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMacMVC.Compnents
{
    public class CategoriaMenu : ViewComponent
    {
        private readonly ICategoriaRepository _categoriaReposity;

        public CategoriaMenu(ICategoriaRepository categoriaReposity)
        {
            _categoriaReposity = categoriaReposity;
        }
        public IViewComponentResult Invoke()
        {
            var categorias = _categoriaReposity.Categorias.OrderBy(c => c.CategoriaNome);
            return View(categorias);
        }
    }
}
