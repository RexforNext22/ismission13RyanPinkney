using System;
using System.Linq;
using ismission13RyanPinkney.Models;
using Microsoft.AspNetCore.Mvc;

namespace ismission13RyanPinkney.Components
{
    public class TeamsViewComponent : ViewComponent
    {

        private IBowlersRepository repo { get; set; }

        public TeamsViewComponent(IBowlersRepository temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {

            ViewBag.SelectedType = RouteData?.Values["teamNames"];


            var teams = repo.Teams
                .Select(x => x.TeamName)
                .Distinct()
                .OrderBy(x => x);

            return View(teams);
        }

    


    
 
    }
}
