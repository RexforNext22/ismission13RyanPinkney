// Author Ryan Pinkney
// This is the context file for the repository.

using System;
using Microsoft.EntityFrameworkCore;

namespace ismission13RyanPinkney.Models
{
    public class BowlingContext : DbContext
    {

        // Constructor
        public BowlingContext(DbContextOptions<BowlingContext> options) : base(options)
        {

        }

        // Set the bowler model
        public DbSet<Bowler> bowlers { get; set; }


        // set the team model
        public DbSet<Team> teams { get; set; }




    }
}
