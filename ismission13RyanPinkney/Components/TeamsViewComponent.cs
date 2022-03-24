// Author Ryan Pinkney
// This is the models for the teams view component

using System;
using System.Linq;
using ismission13RyanPinkney.Models;
using Microsoft.AspNetCore.Mvc;

namespace ismission13RyanPinkney.Components
{
    // Inherit for the viewcomponent 
    public class TeamsViewComponent : ViewComponent
    {

        private IBowlersRepository repo { get; set; }

        // Set the contructor
        public TeamsViewComponent(IBowlersRepository temp)
        {
            repo = temp;
        }

        // Grab the information for the repository and decide whay will be returned to the view component
        public IViewComponentResult Invoke()
        {
            // Set the view bag
            ViewBag.SelectedType = RouteData?.Values["teamNames"];

            // Get the data
            var teams = repo.Teams
                .Select(x => x.TeamName)
                .Distinct()
                .OrderBy(x => x);


            // Return the team names
            return View(teams);
        }

    


    
 
    }
}
