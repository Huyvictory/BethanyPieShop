using Microsoft.AspNetCore.Mvc;

namespace BethanyPieShop.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
