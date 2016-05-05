using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WebApplication1.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private TripRepository rep;

        public HomeController(TripRepository repository)
        {
            rep = repository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {

            ViewBag.Trip = new Trip()
            {
                Name = "Sample Trip",
                Date = DateTime.Today
            };
            return View();
        }
        
        public IActionResult About()
        {
            return View();
        }
        
        public IActionResult Contact()
        {
            return View();
        }
    }
}
