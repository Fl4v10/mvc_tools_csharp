using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCTools.Models;

namespace MVCTools.Controllers
{
    public class ResumeController : Controller
    {
        [HttpGet]
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
    }
}
