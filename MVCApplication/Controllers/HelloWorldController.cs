using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;

namespace MVCApplication.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<Dog> dogs = new List<Dog>
        {
            new Dog { Name = "Buddy", Age = 3 },
            new Dog { Name = "Max", Age = 5 },
            new Dog { Name = "Bella", Age = 2 }
        };

        public IActionResult Index()
        {
            return View(dogs);
        }

        public IActionResult Create()
        {
            Dog dog = new Dog();
            return View();
        }

        public IActionResult CreateDog(Dog dog)
        {
            dogs.Add(dog);
            return RedirectToAction("Index");
        }

        public string Hello()
        {
            return "Hello from Hello action!";
        }
    }
}
