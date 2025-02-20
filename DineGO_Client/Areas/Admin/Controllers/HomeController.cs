using Microsoft.AspNetCore.Mvc;

namespace DineGO_Client.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }
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


        public IActionResult Category()
        {
            return View();
        }

        public IActionResult AddCategory()
        {
            return View();
        }

        public IActionResult UpdateCategory()
        {
            return View();
        }

        public IActionResult DeleteCategory()
        {
            return View();
        }

        public IActionResult Reservation()
        {
            return View();
        }
        public IActionResult AddReservation()
        {
            return View();
        }
        public IActionResult UpdateReservation()
        {
            return View();
        }

        public IActionResult DeleteReservation()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult AddBlog()
        {
            return View();
        }

        public IActionResult UpdateBlog()
        {
            return View();
        }

        public IActionResult DeleteBlog()
        {
            return View();
        }

        public IActionResult Customer()
        {
            return View();
        }

        public IActionResult AddCustomer()
        {
            return View();
        }

        public IActionResult UpdateCustomer()
        {
            return View();
        }

        public IActionResult DeleteCustomer()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }
    }
}