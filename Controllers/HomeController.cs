using Microsoft.AspNetCore.Mvc;
using ShreeKrupaEngg.Models;
using System.Diagnostics;

namespace ShreeKrupaEngg.Controllers
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
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Enquiry()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Enquiry(EnquiryModel model)
        {
            if (ModelState.IsValid)
            {
                // TODO: Save to database or send email
                TempData["Success"] = "Your enquiry has been submitted successfully. We will contact you soon!";
                return RedirectToAction("Enquiry");
            }
            return View(model);
        }

        public IActionResult Gallery()
        {
            return View();
        }

        public IActionResult Locations()
        {
            return View();
        }

        public IActionResult Pipeline()
        {
            return View();
        }

        public IActionResult Infrastructure()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
