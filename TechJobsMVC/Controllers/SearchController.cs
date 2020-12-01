using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobsMVC.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsMVC.Controllers
{
    public class SearchController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            //ViewBag.columns = ListController.ColumnChoices;
            ViewBag.title = "Search";
            ViewBag.selected = "All";
            return View();
        }

        public IActionResult Results(string searchType, string searchTerm)
        {
            if (searchTerm == null)
            {
                ViewBag.selected = searchType;
                ViewBag.error = "Please enter a keyword.";
                return View("Index");

            }
            IEnumerable<Dictionary<string, string>> jobs = new List<Dictionary<string, string>>();
            if (searchType == "All")
            {
                jobs = JobData.FindByValue(searchTerm);
            }
            else
            {
                jobs = JobData.FindByColumnAndValue(searchType, searchTerm);
            }
            ViewBag.jobs = jobs;
            //ViewBag.columns = ListController.columnChoices;
            ViewBag.selected = searchType;
            ViewBag.column = searchType;
            ViewBag.search = searchTerm;

            return View("Index");
        }


    }
}

