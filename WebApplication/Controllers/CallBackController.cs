using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallBackController : ControllerBase
    {
        [HttpGet]
        [Route("principal")]
        public IActionResult Index()
        {
            try
            {
                return Ok("Sucesso na chamada");
            }
            catch (Exception)
            {
                return BadRequest("Ocorreu um erro na chamada da nossa api");
            }
        }

        [HttpGet]
        [Route("principal/{id}")]
        public IActionResult Index(string id)
        {
            try
            {
                return Ok("Sucesso na chamada com id");
            }
            catch (Exception)
            {
                return BadRequest("Ocorreu um erro na chamada da nossa api");
            }
        }
    }


}
