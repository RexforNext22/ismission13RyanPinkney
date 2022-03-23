using System;
using System.Linq;

namespace ismission13RyanPinkney.Models
{
    public interface IBowlersRepository
    {

        IQueryable<Bowler> Bowlers { get; }



    }
}
