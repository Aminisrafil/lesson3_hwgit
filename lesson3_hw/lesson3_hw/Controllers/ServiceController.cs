using lesson3_hw.Models;
using Microsoft.AspNetCore.Mvc;

namespace lesson3_hw.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View(Data.Services);
        }
    }
}
