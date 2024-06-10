using FeverWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FeverWebApp.Controllers
{
    public class DoctorController : Controller
    {
        
        [HttpGet]
        public ActionResult FeverCheck()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken] 
        public ActionResult CheckFever(float temperature, string scale)
        {
            string message = TemperatureChecker.CheckTemperature(temperature, scale);
            ViewBag.Message = message;
            return View("FeverCheck"); 
        }
    }
}
