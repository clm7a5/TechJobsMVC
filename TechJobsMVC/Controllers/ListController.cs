using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobsMVC.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsMVC.Controllers
{
    public class ListController : Controller
    {
       
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Values(string column)
        {
            if (column.Equals("All"))
            {
                IEnumerable<Dictionary<string, string>> jobs = JobData.FindAll();
                ViewBag.title = "All Jobs";
                ViewBag.jobs = jobs;
                return View("Jobs");
            }
            else
            {
                IList<string> items = JobData.FindAll(column);
                ViewBag.title = "All " + column + " Values";
                ViewBag.column = column;
                ViewBag.items = items;
                return View();
            }
        }

        public IActionResult Jobs(string column, string value)
        {
            IEnumerable<Dictionary<String, String>> jobs = JobData.FindByColumnAndValue(column, value);
            ViewBag.title = "Jobs with " + column + ": " + value;
            ViewBag.jobs = jobs;

            return View();
        }
    }
}