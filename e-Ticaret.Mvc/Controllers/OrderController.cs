using Microsoft.AspNetCore.Mvc;

namespace e_Ticaret.Mvc.Controllers
{
    public class OrderController : Controller
    {
        [Route("/create-new-order")]
        public IActionResult Create()
        {
            return View();
        }
        [Route("/order-details/{id}")]
        public IActionResult Details()
        {
            return View();
        }
    }
}
