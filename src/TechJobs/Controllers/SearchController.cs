using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View();
        }

        // Results action method to process search requests and display results
        public IActionResult Results(string searchType, string searchTerm)
        {
            ViewBag.columns = ListController.columnChoices;

            if (searchTerm != null)
            {
                ViewBag.jobs = JobData.FindByValue(searchTerm);
                ViewBag.searchTerm = searchTerm;
            }

            return View("Index");
        }
    }
}
