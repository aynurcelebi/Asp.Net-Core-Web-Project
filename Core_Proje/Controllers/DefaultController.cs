using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    // Backend tarafında yazılacak kodlar burda olacak. Mimariyi tanımlamış olduğumuz metotları burda çağıracağız.
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
