using Microsoft.AspNetCore.Mvc;

namespace DineGO_Client.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CustomerController : Controller
    {
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
    }
}