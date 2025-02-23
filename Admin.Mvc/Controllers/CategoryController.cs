using Microsoft.AspNetCore.Mvc;

namespace Admin.Mvc.Controllers
{
    public class CategoryController : Controller
    {
        [Route("/category-create/{title}")]
        public IActionResult Create()
        {
            return View();
        }
        [Route("/category-edit")]
        public IActionResult Edit()
        {
            return View();
        }
        [Route("/category-delete/{id}")]
        public IActionResult Delete()
        {
            return View();
        }
    }
}
