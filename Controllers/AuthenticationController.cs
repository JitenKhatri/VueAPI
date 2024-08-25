using Microsoft.AspNetCore.Mvc;

namespace VueAPI.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
