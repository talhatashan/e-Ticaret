using Microsoft.AspNetCore.Mvc;

namespace e_Ticaret.Mvc.Controllers
{
    public class CartController : Controller
    {
        [Route("/cart-register-product")]
        public IActionResult AddProduct()
        {
            return View();
        }
        [Route("/edit-cart/{id}")]
        public IActionResult Edit()
        {
            return View();
        }
    }
}
