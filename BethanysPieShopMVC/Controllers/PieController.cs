using BethanysPieShopMVC.Repository;
using BethanysPieShopMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShopMVC.Controllers
{
    public class PieController : Controller
    {

        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            this._pieRepository = pieRepository;
            this._categoryRepository = categoryRepository;
        }
        public ViewResult List()
        {
            var piesListViewModel = new PiesListViewModel()
            {
                Pies = _pieRepository.AllPies,
                CurrentCategory = "Cheese cakes"
            };

            return View(piesListViewModel);
        }
        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if (pie == null)
                return NotFound();
            return View(pie);
        }
    }
}
