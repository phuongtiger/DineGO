using Microsoft.AspNetCore.Mvc;

namespace DineGO_Client.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RestaurantController : Controller
    {
         public IActionResult Restaurant()
        {
            return View();
        }
        public IActionResult AddRestaurant()
        {
            return View();
        }
        public IActionResult UpdateRestaurant()
        {
            return View();
        }
        public IActionResult DeleteRestaurant()
        {
            return View();
        }
    }
}