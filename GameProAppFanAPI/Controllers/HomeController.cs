using GameProAppFanAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameProAppFanAPI.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext _context;
        public HomeController(ApplicationContext pussy)
        {
            _context = pussy;
        }
       
        public IActionResult Porno() {
            _context.Database.EnsureCreated();
            return StatusCode(17, "Slavic"); }
    }
}
