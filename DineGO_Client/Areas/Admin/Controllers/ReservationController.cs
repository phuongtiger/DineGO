using Microsoft.AspNetCore.Mvc;

namespace DineGO_Client.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ReservationController : Controller
    {
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
    }
}