using Microsoft.AspNetCore.Mvc;

namespace DeviceManagerBackend.Controllers
{
    public class SpaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
