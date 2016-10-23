using Microsoft.AspNetCore.Mvc;

namespace PilotoQ1Net.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("~/wwwroot/app/index.html");
        }
    }
}