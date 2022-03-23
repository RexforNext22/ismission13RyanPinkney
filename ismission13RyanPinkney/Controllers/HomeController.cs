using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ismission13RyanPinkney.Models;
using Microsoft.EntityFrameworkCore;

namespace ismission13RyanPinkney.Controllers
{
    public class HomeController : Controller
    {
        // Repo
        private IBowlersRepository repo;

        public HomeController(IBowlersRepository temp)
        {
            repo = temp;
        }


        // Path for the index
        public IActionResult Index()
        {
            return View();
        }

        // Path to see all the bowlers
        public IActionResult List()
        {

            // Get all the bowlers
            var BowlerList = repo.Bowlers
                .Include(x => x.Team)
                .ToList();

            return View(BowlerList);
        }


        // Route for the get Movie
        [HttpGet]
        public IActionResult Add()
        {

            // Fill the bag
            ViewBag.lstTeams = repo.Teams.ToList();

            return View();
        }

        // Route for the post Movie
        [HttpPost]
        public IActionResult Add(Bowler response)
        {
            // Check to see if the data inputed is valid
            if (!ModelState.IsValid)
            {
                // Load the bag
                ViewBag.lstCategories = repo.Teams.ToList();


                return View(response);
            }

            // Save the infomration to the database
            repo.CreateBowler(response);

            // Return them to the confirmation page
            return View("Index");
        }


    }
}
