using BethanysPieShopMVC.Models;
using System.Collections.Generic;

namespace BethanysPieShopMVC.Repository
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get; }
        IEnumerable<Pie> PiesOfTheWeek { get; }
        Pie GetPieById(int pieId);
    }
}
