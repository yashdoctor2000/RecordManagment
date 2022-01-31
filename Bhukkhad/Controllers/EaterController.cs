using Microsoft.AspNetCore.Mvc;

namespace Bhukkhad.Controllers
{
    public class EaterController : Controller
    {
        //Actionmethod
        public IActionResult EaterHome()
        {
            return View();
        }
        public IActionResult EaterLogin()
        {
            return View();
        }
        public IActionResult EaterChangePassword()
        {
            return View();
        }
        public IActionResult EaterBookMe()
        {
            return View();
        }
        public IActionResult EaterAboutUs()
        {
            return View();
        }
        public IActionResult EaterHelp()
        {
            return View();
        }      
    }
}
