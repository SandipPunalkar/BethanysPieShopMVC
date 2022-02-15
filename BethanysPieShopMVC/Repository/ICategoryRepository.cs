using BethanysPieShopMVC.Models;
using System.Collections.Generic;

namespace BethanysPieShopMVC.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }

    }
}
