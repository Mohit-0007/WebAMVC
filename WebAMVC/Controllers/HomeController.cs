using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebAMVC.Models;

namespace WebAMVC.Controllers
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
            ViewData["Title"] = "Home";
            ViewData["Description"] = "Home page description";
            ViewData["Keywords"] = "Home, Home page";
            return View();
        }

        public IActionResult BlogDetails()
        {
            ViewData["Title"] = "Blog-Details";
            ViewData["Description"] = "Blog-Details page description";
            ViewData["Keywords"] = "Blog, Blog details,blogs";
            return View();
        }
        public IActionResult About()
        {
            ViewData["Title"] = "About";
            ViewData["Description"] = "About page description";
            ViewData["Keywords"] = "About, About page,about section";
            return View();
        }
        public IActionResult Blog()
        {
            ViewData["Title"] = "Blog";
            ViewData["Description"] = "Blog us page description";
            ViewData["Keywords"] = "Blog, blog page";
            return View();
        }
        public IActionResult Contact()
        {
            ViewData["Title"] = "Contact Us";
            ViewData["Description"] = "Contact us page description";
            ViewData["Keywords"] = "Contact, Contact page,Support";
            return View();
        }
        public IActionResult Projects()
        {
            ViewData["Title"] = "Projects";
            ViewData["Description"] = "Project page description";
            ViewData["Keywords"] = "Project, Project page,Projects";
            return View();
        }
        public IActionResult ProjectDetails()
        {
            ViewData["Title"] = "ProjectDetails";
            ViewData["Description"] = "ProjectDetails page description";
            ViewData["Keywords"] = "ProjectDetails, project detail,project";
            return View();
        }
        public IActionResult NotFound()
        {
            ViewData["Title"] = "NotFound";
            ViewData["Description"] = "Notfound page description";
            ViewData["Keywords"] = "Error,Error page,Not found";
            return View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
