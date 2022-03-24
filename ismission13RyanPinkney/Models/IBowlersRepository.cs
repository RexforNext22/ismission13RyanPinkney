// Author Ryan Pinkney
// This is the "I" file for the repository pattern

using System;
using System.Linq;

namespace ismission13RyanPinkney.Models
{
    // Interface designed to be inherited from
    public interface IBowlersRepository
    {
        // Set the iquerables
        IQueryable<Bowler> Bowlers { get; }
        IQueryable<Team> Teams { get; }



        // Define the functions that will be implemented later
        public void SaveBowler(Bowler b);
        public void UpdateBowler(Bowler b);
        public void CreateBowler(Bowler b);
        public void DeleteBowler(Bowler b);


    }
}
