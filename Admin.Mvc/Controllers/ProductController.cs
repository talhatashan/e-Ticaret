using Microsoft.AspNetCore.Mvc;

namespace Admin.Mvc.Controllers
{
    public class ProductController : Controller
    {
        [Route("/product/delete/{id}")]
        public IActionResult Delete()
        {
            return View();
        }
    }
}
