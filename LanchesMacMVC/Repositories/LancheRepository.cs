using LanchesMacMVC.Context;
using LanchesMacMVC.Models;
using LanchesMacMVC.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMacMVC.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _Context;

        public LancheRepository(AppDbContext context)
        {
            _Context = context;
        }
        public IEnumerable<Lanche> Lanches => _Context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _Context.Lanches.Where(p => p.IsLanchePreferido).Include(c=> c.Categoria);

        public Lanche GetLancheById(int LancheId)
        {
            return _Context.Lanches.FirstOrDefault(l => l.LancheId == LancheId);
        }
    }
}
