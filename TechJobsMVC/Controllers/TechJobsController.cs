using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TechJobsMVC.Controllers
{
    public class TechJobsController : Controller
    {

        internal static IDictionary<string, string> actionChoices = new Dictionary<string, string>();
        internal static IDictionary<string, string> columnChoices = new Dictionary<string, string>();


        static TechJobsController()
        {

            actionChoices.Add("search", "Search");
            actionChoices.Add("list", "List");

            columnChoices.Add("Core Competency", "Skill");
            columnChoices.Add("Employer", "Employer");
            columnChoices.Add("Location", "Location");
            columnChoices.Add("Position Type", "Position Type");
            columnChoices.Add("All", "All");

        }

        public override ViewResult View()
        {
            ViewBag.actions = actionChoices;
            ViewBag.columns = columnChoices;

            return base.View();
        }

        public override ViewResult View(string viewName)
        {
            ViewBag.actions = actionChoices;
            ViewBag.columns = columnChoices;

            return base.View(viewName);

        }

    }
}