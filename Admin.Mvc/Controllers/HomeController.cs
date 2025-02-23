using Admin.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Admin.Mvc.Controllers
{
    public class HomeController : Controller
    {

        [Route("home-index")]
        public IActionResult Index()
        {
            return View();
        }

       
    }
}
