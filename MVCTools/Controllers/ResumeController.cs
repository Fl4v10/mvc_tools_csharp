using Microsoft.AspNetCore.Mvc;

namespace MVCTools.Controllers
{
    public class ResumeController : Controller
    {
        [HttpGet("home")]
        public IActionResult Index()
        {
            ViewBag.Title = "Sobre Mim";
            return View();
        }

        [HttpGet("experience")]
        public IActionResult Experience()
        {
            ViewBag.Title = "Experiência";
            return View();
        }

        [HttpGet("education")]
        public IActionResult Education()
        {
            ViewBag.Title = "Formação";
            return View();
        }

        [HttpGet("skills")]
        public IActionResult Skills()
        {
            ViewBag.Title = "Habilidades";
            return View();
        }

        [HttpGet("interests")]
        public IActionResult Interests()
        {
            ViewBag.Title = "Interesses";
            return View();
        }

        [Route("{*url}")]
        public IActionResult CatchAll()
        {
            Response.StatusCode = 404;
            return View();
        }
    }
}
