using BethanysPieShopMVC.Models;
using System.Collections.Generic;

namespace BethanysPieShopMVC.ViewModels
{
    public class PiesListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
