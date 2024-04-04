using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    
    public class ClienteController : Controller
    {
        [Route("cli/principal")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("cli/json")]
        public IActionResult RetornoJson()
        {
            return Json("Retorno JSON");
        }

        [Route("cli/json/{id}")]
        public IActionResult RetornoJson(string id)
        {
            return Json("Retorno JSON com ID");
        }
    }
}
