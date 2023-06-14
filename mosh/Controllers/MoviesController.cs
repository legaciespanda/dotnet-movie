using Microsoft.AspNetCore.Mvc;
using mosh.Models;

namespace mosh.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Random()
        {
            var movie = new MovieModel() { 
                Id=1, 
                Author="Ernest", 
                Name="Developing ASP.NET MVC",
                Title="Developing ASP.NET MVC",
                Description="Learn hoe to develope ASP.NET MVC APPLICATION",
                Url = "https://asp.net"
            };

            ViewBag.name = "Ernest";
            ViewData["occupation"] = "Software Engineer";
            TempData["work"] = "Zido";

            return View(); 
        }
    }
}
