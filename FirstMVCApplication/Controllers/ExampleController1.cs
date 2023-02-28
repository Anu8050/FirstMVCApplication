using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApplication.Controllers
{
    public class ExampleController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
