using lesson3_hw.Models;
using Microsoft.AspNetCore.Mvc;

namespace lesson3_hw.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            
            return View(Data.Teams);
        }
        public IActionResult Detail(int id)
        {
            Team teams = Data.Teams.Find(x => x.Id == id);

            return View(teams);
        }
    }
}
