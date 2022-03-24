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

    public IQueryable<Team> Teams => context.teams;



        // For the admin interface
        public void SaveBowler(Bowler b)
        {

            context.SaveChanges();
        }

        public void UpdateBowler(Bowler b)
        {
            context.Update(b);
            context.SaveChanges();
        }

        public void CreateBowler(Bowler b)
        {
            context.Add(b);
            context.SaveChanges();
        }

        public void DeleteBowler(Bowler b)
        {
            context.Remove(b);
            context.SaveChanges();
        }





    }
}
