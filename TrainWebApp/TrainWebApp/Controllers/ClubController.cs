using Microsoft.AspNetCore.Mvc;
using TrainWebApp.Data;
using TrainWebApp.Models;

namespace TrainWebApp.Controllers
{
    public class ClubController : Controller
    {
        private ApplicationDbContext _context;

        public ClubController(ApplicationDbContext context)
        {
            _context = context;
            
        }
        public IActionResult Index()
        {
            List<Club> clubs = _context.Clubs.ToList();
            return View(clubs);
        }
    }
}
