using Microsoft.AspNetCore.Mvc;
using TrainWebApp.Data;
using TrainWebApp.Models;

namespace TrainWebApp.Controllers
{
    public class RaceController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RaceController(ApplicationDbContext context)
        {
            _context = context;
            
        }
        public IActionResult Index()
        {
            List<Race> races = _context.Races.ToList();
            return View(races);
        }
    }
}
