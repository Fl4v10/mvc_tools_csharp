using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCTools.Models;

namespace MVCTools.Controllers
{
    public class ResumeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Sobre Mim";
            return View();
        }

        public IActionResult Experience()
        {
            ViewBag.Title = "Experiência";
            return View();
        }

        public IActionResult Education()
        {
            ViewBag.Title = "Formação";
            return View();
        }

        public IActionResult Skills()
        {
            ViewBag.Title = "Habilidades";
            return View();
        }

        public IActionResult Interests()
        {
            ViewBag.Title = "Interesses";
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
