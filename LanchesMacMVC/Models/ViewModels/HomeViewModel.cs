using System.Collections.Generic;

namespace LanchesMacMVC.Models.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Lanche> LanchesPreferidos { get; set; }
    }
}
