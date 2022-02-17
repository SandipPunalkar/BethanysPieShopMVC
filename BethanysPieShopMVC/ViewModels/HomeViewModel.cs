using BethanysPieShopMVC.Models;
using System.Collections.Generic;

namespace BethanysPieShopMVC.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
        
    }
}
