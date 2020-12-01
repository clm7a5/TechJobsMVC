
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TechJobsMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
