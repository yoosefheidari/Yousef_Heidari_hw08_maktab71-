using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Yousef_Heidari_hw08_maktab71.Models;

namespace Yousef_Heidari_hw08_maktab71.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var persons= PersonRepository.GetAll();
            return View(persons);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View("Contact");
        }
        public IActionResult Delete(int id)
        {
            PersonRepository.Delete(id);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {var currentPerson=PersonRepository.Find(id);
            return View(currentPerson);
        }
        [HttpPost]
        public IActionResult Edit(Person person)
        {
            var currentPerson=PersonRepository.Find(person.Id);
            currentPerson.Name=person.Name;
            return RedirectToAction("Index");
        }
        public IActionResult Layout()
        {
            return View("NewLayout");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}