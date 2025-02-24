using Microsoft.AspNetCore.Mvc;

namespace DineGO_Client.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
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
    }
}