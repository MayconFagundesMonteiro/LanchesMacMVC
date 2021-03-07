using LanchesMacMVC.Context;
using LanchesMacMVC.Models;
using LanchesMacMVC.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMacMVC.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _Context;

        public CategoriaRepository(AppDbContext context)
        {
            _Context = context;
        }
        public IEnumerable<Categoria> Categorias => _Context.Categorias;
    }
}
