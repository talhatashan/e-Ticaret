using Microsoft.AspNetCore.Mvc;

namespace Admin.Mvc.Controllers
{
    public class UserController : Controller
    {
        [Route("user-list")]
        public IActionResult List()
        {
            return View();
        }
        [Route("user-approve")]
        public IActionResult Approve()
        {
            return View();
        }
    }
}
