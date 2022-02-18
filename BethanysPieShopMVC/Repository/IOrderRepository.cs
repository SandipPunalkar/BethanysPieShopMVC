using BethanysPieShopMVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopMVC.Repository
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
