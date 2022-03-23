using System;
using System.Linq;

namespace ismission13RyanPinkney.Models
{
    public class EFBowlersRepository : IBowlersRepository
    {

    private BowlingContext context { get; set; }

    public EFBowlersRepository(BowlingContext temp)
    {
        context = temp;
    }


    public IQueryable<Bowler> Bowlers => context.bowlers;





    }
}
