using Microsoft.AspNetCore.Mvc;

namespace MVCTools.Controllers
{
    public class ResumeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return RedirectToAction("About");
        }

        [HttpGet]
        [Route("About")]
        public IActionResult About()
        {
            ViewBag.Title = "Sobre Mim";
            return View();
        }

        [HttpGet]
        [Route("experience")]
        public IActionResult Experience()
        {
            ViewBag.Title = "Experiência";
            return View();
        }

        [HttpGet]
        [Route("education")]
        public IActionResult Education()
        {
            ViewBag.Title = "Formação";
            return View();
        }

        [HttpGet]
        [Route("skills")]
        public IActionResult Skills()
        {
            ViewBag.Title = "Habilidades";
            return View();
        }

        [HttpGet]
        [Route("interests")]
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
