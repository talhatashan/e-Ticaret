using Microsoft.AspNetCore.Mvc;

namespace Admin.Mvc.Controllers
{
    public class CommentController : Controller
    {
        [Route("/comment-list")]
        public IActionResult List()
        {
            return View();
        }
        [Route("comment-approve")]
        public IActionResult Approve()
        {
            return View();
        }
    }
}
