using dotnet_mvc_first_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_mvc_first_app.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // cek hardcode (belum DB)
            if (model.Email == "admin@gmail.com" && model.Password == "123")
            {
                HttpContext.Session.SetString("Email", model.Email);
                HttpContext.Session.SetString("IsLoggedIn", "true"); // <--- tambahin ini
                return RedirectToAction("Index", "Dashboard");
            }

            ViewBag.Error = "Email atau Password salah!";
            return View(model);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
