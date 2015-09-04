using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemaXP.ModelLayer;

namespace TemaXP.DBLayer
{
    public class AuctionRepository : SuperRepository
    {

        public void InsertAuction(Auction auction)
        {
            context.Auctions.Add(auction);
            Save();
        }

        public Auction FindAuction(int id)
        {
            return context.Auctions.Find(id);
        }

        public void DeleteAuction(int id)
        {
            context.Auctions.Remove(FindAuction(id));
            Save();
        }

        public List<Auction> GetAllAuctions()
        {
            return context.Auctions.ToList();
        }
    }
}
