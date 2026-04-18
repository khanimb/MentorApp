using System.Diagnostics;
using MentorApp.Data;
using MentorApp.Models;
using MentorApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MentorApp.Controllers
{
    public class HomeController(MentorDbContext context) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var slider = await context.Sliders.FirstOrDefaultAsync();
            HomeVm homeVm = new HomeVm
            {
                Slider = slider
            };
            return View(homeVm);
        }
    }
}
