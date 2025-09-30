using Microsoft.AspNetCore.Mvc;

namespace dotnet_mvc_first_app.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("IsLoggedIn") != "true")
            {
                return RedirectToAction("Login", "Account");
            }

            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                return PartialView();

            return View();
        }

        public IActionResult Index2()
        {
            if (HttpContext.Session.GetString("IsLoggedIn") != "true")
            {
                return RedirectToAction("Login", "Account");
            }

            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                return PartialView();

            return View();
        }

        public IActionResult Index3()
        {
            if (HttpContext.Session.GetString("IsLoggedIn") != "true")
            {
                return RedirectToAction("Login", "Account");
            }

            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                return PartialView();

            return View();
        }
    }
}
