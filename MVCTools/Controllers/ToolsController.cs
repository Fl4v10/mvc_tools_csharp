using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCTools.Models;

namespace MVCTools.Controllers
{
    public class ToolsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
