using IntroAspNetMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IntroAspNetMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IWorkoutRepository _workoutRepository;

        public HomeController(ILogger<HomeController> logger, IWorkoutRepository workoutRepository) {
            _logger = logger;
            _workoutRepository = workoutRepository;
        }

        public IActionResult Index() {
            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        public IActionResult Workouts() {
            var workouts = _workoutRepository.AllWorkouts.ToList();
            return View(workouts);
        }

        public IActionResult Details(int? id) {
            if (id == null) {
                return NotFound();
            }

            var workout = _workoutRepository.AllWorkouts
                .FirstOrDefault(workout => workout.Id == id);
            if (workout == null) {
                return NotFound();
            }

            return View(workout);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}