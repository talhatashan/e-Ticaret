using Microsoft.AspNetCore.Mvc;

namespace e_Ticaret.Mvc.Controllers
{
    public class ProductController : Controller
    {
        [Route("/create-product")]
        public IActionResult Create()
        {
            return View();
        }
        [Route("/edit-product")]
        public IActionResult Edit()
        {
            return View();
        }
        [Route("/delete-product/{id}")]
        public IActionResult Delete()
        {
            return View();
        }
        [Route("/commet-product/{id}")]
        public IActionResult Comment()
        {
            return View();
        }
    }
}
