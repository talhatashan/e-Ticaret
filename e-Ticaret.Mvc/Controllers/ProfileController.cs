using Microsoft.AspNetCore.Mvc;

namespace e_Ticaret.Mvc.Controllers
{
    public class ProfileController : Controller
    {
        [Route("/profile-details")]
        public IActionResult Details()
        {
            return View();
        }
        [Route("/profile-edit")]
        public IActionResult Edit()
        {
            return View();
        }
        [Route("/profile-my-orders/{id}/orders")]
        public IActionResult MyOrders()
        {
            return View();
        }
        [Route("/profile-my-products/{id}/products")]
        public IActionResult MyProducts()
        {
            return View();
        }
    }
}
