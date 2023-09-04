using Microsoft.AspNetCore.Mvc;
using Ch02Ex1FutureValue.Models;

namespace Ch02Ex1FutureValue.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FV = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Indux(FutureValueModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FV = model.CalculateFutureValue();
            }
            else 
            {
                ViewBag.FV = 0;
            }
            return View(model);
        }
    }
}
