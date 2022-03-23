using System;
using System.Linq;

namespace ismission13RyanPinkney.Models
{
    public interface IBowlersRepository
    {

        IQueryable<Bowler> Bowlers { get; }
        IQueryable<Bowler> Teams { get; }



        // For the admin interface
        public void SaveBowler(Bowler b);
        public void CreateBowler(Bowler b);
        public void DeleteBowler(Bowler b);


    }
}
