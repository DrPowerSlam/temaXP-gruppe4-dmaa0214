using System.Collections.Generic;
using TemaXP.DBLayer;
using TemaXP.ModelLayer;

namespace TemaXP.CtrLayer
{
    public class AuctionCtr
    {
        private AuctionRepository repos;

        public AuctionCtr()
        {
            repos = new AuctionRepository();
        }

        public void InsertAuction(Auction auction)
        {
            repos.InsertAuction(auction);
        }

        public Auction FindAuction(int id)
        {
            return repos.FindAuction(id);
        }

        public List<Auction> GetAllAuctions()
        {
            return repos.GetAllAuctions();
        }

        public void DeleteAuction(int id)
        {
            repos.DeleteAuction(id);
        }
    }
}