using _04ContactFormSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Runtime;

namespace _04ContactFormSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]//For fetching the form
        public IActionResult ContactPage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactPage(ContactModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            ViewBag.Message= $"Form submitted successfully! Thank you {model.Name}";

            ViewBag.Name = model.Name;
            ViewBag.Email = model.Email;
            ViewBag.MessageContent = model.Message;

            ModelState.Clear(); // Clear the form after successful submission
            return View(new ContactModel());
        }
    }
}
