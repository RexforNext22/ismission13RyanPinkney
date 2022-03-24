// Author Ryan Pinkney
// This is my ef repoistory for the bowers

using System;
using System.Linq;

namespace ismission13RyanPinkney.Models
{
    // Inherit from the interface
    public class EFBowlersRepository : IBowlersRepository
    {

        // Set the context
    private BowlingContext context { get; set; }

        // Set the contructor
    public EFBowlersRepository(BowlingContext temp)
    {
        context = temp;
    }

        // Set the iqueryable for the bowlers and teams
    public IQueryable<Bowler> Bowlers => context.bowlers;

    public IQueryable<Team> Teams => context.teams;



        // Save changes to the database function
        public void SaveBowler(Bowler b)
        {

            context.SaveChanges();
        }

        // Update the database function
        public void UpdateBowler(Bowler b)
        {
            context.Update(b);
            context.SaveChanges();
        }

        // Create a new bowler function
        public void CreateBowler(Bowler b)
        {
            context.Add(b);
            context.SaveChanges();
        }

        // Delete a bowler from the database function
        public void DeleteBowler(Bowler b)
        {
            context.Remove(b);
            context.SaveChanges();
        }





    }
}
