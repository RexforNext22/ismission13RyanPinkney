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

    }
}
