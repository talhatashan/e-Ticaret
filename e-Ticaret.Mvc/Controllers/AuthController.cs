using Microsoft.AspNetCore.Mvc;

namespace e_Ticaret.Mvc.Controllers
{
    public class AuthController : Controller
    {
        [Route("/register-auth")]
        public IActionResult Register()
        {
            return View();
        }

        [Route("/login-auth/{id}")]
        public IActionResult Login()
        {
            return View();
        }
        [Route("/auth-forgot-password/{email}")]
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [Route("auth-logout")]
        public IActionResult Logout()
        {
            return View();
        }
    }
}
