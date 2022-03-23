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

        public DbSet<Bowler> bowlers { get; set; }

        public DbSet<Team> teams { get; set; }




    }
}
