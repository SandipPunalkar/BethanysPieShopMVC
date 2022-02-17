using Microsoft.AspNetCore.Mvc;
using System.Linq;
using BethanysPieShopMVC.Repository;
using BethanysPieShopMVC.Models;
using BethanysPieShopMVC.ViewModels;

namespace BethanysPieShopMVC.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IPieRepository pieRepository,ShoppingCart shoppingCart)
        {
            this._pieRepository = pieRepository;
            this._shoppingCart = shoppingCart;
        }
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int pieId)
        {
            var selectedPie = _pieRepository.AllPies.FirstOrDefault(p => p.PieId == pieId);

            if (selectedPie != null)
                _shoppingCart.AddToCart(selectedPie, 1);

            return RedirectToAction("Index");
        }
        public RedirectToActionResult RemoveFromShoppingCart(int pieId)
        {
            var selectedPie = _pieRepository.AllPies.FirstOrDefault(p => p.PieId == pieId);

            if (selectedPie != null)
                _shoppingCart.RemoveFromCart(selectedPie);

            return RedirectToAction("Index");
        }
    }
}
