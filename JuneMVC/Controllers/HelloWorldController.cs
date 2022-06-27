using Microsoft.AspNetCore.Mvc;
using JuneMVC.Models;

namespace JuneMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        private static readonly List<DogViewModel> dogs= new List<DogViewModel>(); 
        public IActionResult Index()
        {

            return View(dogs);
        }

        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            // return View();
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));

        }

        public string Hello()
        {
            return "Who's there?";
        }
    }
}
