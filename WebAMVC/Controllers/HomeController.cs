using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebAMVC.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace WebAMVC.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        private readonly string _constr;
        public HomeController(IConfiguration configuration)
        {
            _constr = configuration.GetConnectionString("DefaultConnection");
        }
        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        private IDbConnection GetConnection() => new SqlConnection(_constr);
        
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
        [HttpGet]
        public IActionResult Contact()
        {
            ViewData["Title"] = "Contact Us";
            ViewData["Description"] = "Contact us page description";
            ViewData["Keywords"] = "Contact, Contact page,Support";
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Contact(User user)
        {
             ModelState.Remove("Id");
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            var connection = GetConnection();
            string sql = "INSERT INTO Users (FirstName, LastName, Email, Phone, Password) VALUES (@FirstName, @LastName, @Email, @Phone, @Password)";
            var result =await connection.ExecuteAsync(sql, user);

            // Here you can handle the form submission, e.g., save to database or send an email

            return RedirectToAction("Index");
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
