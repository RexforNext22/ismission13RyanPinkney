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
        public IActionResult List(string teamNames)
        {

            // Get all the bowlers
            var BowlerList = repo.Bowlers
                .Where(p => p.Team.TeamName == teamNames || teamNames == null)
                .Include(x => x.Team)
                .ToList();

            return View(BowlerList);
        }


        // Route for the get bowler
        [HttpGet]
        public IActionResult Add()
        {

            // Fill the bag
            ViewBag.lstTeams = repo.Teams.ToList();

            return View();
        }

        // Route for the post bowler
        [HttpPost]
        public IActionResult Add(Bowler response)
        {
            // Check to see if the data inputed is valid
            if (!ModelState.IsValid)
            {
                // Load the bag
                ViewBag.lstTeams = repo.Teams.ToList();


                return View(response);
            }

            var oSingleTimeMax = repo.Bowlers.OrderByDescending(u => u.BowlerID).FirstOrDefault();


            response.BowlerID = oSingleTimeMax.BowlerID + 1;

            // Save the infomration to the database
            repo.CreateBowler(response);



            // Return them to the confirmation page
            return RedirectToAction("List");
        }



        // Route to edit get
        [HttpGet]
        public IActionResult Edit(int id)
        {
            // Load the bag
            ViewBag.lstTeams = repo.Teams.ToList();


            // Pull a single record
            var oSingleRecord = repo.Bowlers
            .Single(x => x.BowlerID == id);


            // Return the view with the single object
            return View(oSingleRecord);
        }

        // Route to edit post
        [HttpPost]
        public IActionResult Edit(Bowler b)
        {

            // Check to see if the data inputted was valid
            if (!ModelState.IsValid)
            {

                // Load the bag
                ViewBag.lstTeams = repo.Teams.ToList();

                // Return to waitlist
                return View(b);


            };

            // Save the infomration to the database
            repo.UpdateBowler(b);

            // Redirect to the movie list route
            return RedirectToAction("List");

        }


        // Route to Delete get
        [HttpGet]
        public IActionResult Delete(int id)
        {

            // Pull a single record
            var oSingleRecord = repo.Bowlers
            .Single(x => x.BowlerID == id);


            // Return the view with the single object
            return View(oSingleRecord);
        }

        // Route to delete post
        [HttpPost]
        public IActionResult Delete(Bowler b)
        {
            // Delete the record identifed by the id in the response
            repo.DeleteBowler(b);

            // Redirect to the movie list route
            return RedirectToAction("List");
        }






    }
}
