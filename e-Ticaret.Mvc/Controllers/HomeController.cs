using e_Ticaret.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace e_Ticaret.Mvc.Controllers
{
	public class HomeController : Controller
	{
		

       
        public IActionResult Index()
		{
			return View();
		}
        [Route("/about-us")]
        public IActionResult AboutUs()
		{
			return View();
		}
       
        [Route("/listing-products")]
        public IActionResult Listing()
        {
            return View();
        }
        [Route("/product-detail/{id}")]
        public IActionResult ProductDetail()
        {
            return View();
        }
        [Route("blog")]
        public IActionResult Blog()
        {
            return View();
        }
        [Route("shop-details")]
        public IActionResult ShopDetails()
        {
            return View();
        }
        [Route("shop-grid")]
        public IActionResult ShopGrid()
        {
            return View();
        }
        [Route("contact")]
        public IActionResult Contact()
        {
            return View();
        }

    }
}
