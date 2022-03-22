using Microsoft.AspNetCore.Mvc;

namespace Hub.Controllers
{
    public class SIteController : Controller
    {
        public IActionResult home()
        {
            return View();
        }
    }
}
