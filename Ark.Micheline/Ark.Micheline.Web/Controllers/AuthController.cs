using Microsoft.AspNetCore.Mvc;

namespace Ark.Micheline.Web.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Callback()
        {
            return View();
        }
    }
}
