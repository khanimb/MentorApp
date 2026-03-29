using System.Diagnostics;
using MentorApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MentorApp.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

    }
}
