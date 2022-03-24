using Hub.Models;
using Hub.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Hub.Controllers
{
    public class SiteController : Controller
    {

        private readonly ICadastroRepositorio _cadastroRepositorio;

        public SiteController(ICadastroRepositorio cadastroRepositorio)
        {
            _cadastroRepositorio = cadastroRepositorio;
        }

        public IActionResult home()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(CadastroUsuario cadastro)
        {
            _cadastroRepositorio.Adicionar(cadastro);
            return RedirectToAction("home");
        }
    }
}
