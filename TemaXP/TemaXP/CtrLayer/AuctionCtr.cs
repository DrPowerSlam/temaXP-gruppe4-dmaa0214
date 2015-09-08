using System;
using System.Collections.Generic;
using TemaXP.DBLayer;
using TemaXP.ModelLayer;

namespace TemaXP.CtrLayer
{
    public class AuctionCtr
    {
        public int Index { get; set; }
        public Bid CurrentBid { get; set; }
        public int MaxIndex { get; set; }

        private AuctionRepository repos;

        public AuctionCtr()
        {
            repos = new AuctionRepository();
        }

        public void InsertAuction(Auction auction)
        {
            repos.InsertAuction(auction);
        }

        public void RegisterSale()
        {
            if (CurrentBid != null)
            {
                CurrentBid.Member.Points -= (CurrentBid.Amount / 3);
                CurrentBid.Item.Sold = true;
            }
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

        //TODO validere at admin kun kan oprette en auktion per år
        public Auction GetCurrentAuction()
        {
            return GetAllAuctions().Find(c => c.Date.Year == DateTime.Now.Year);
        }
    }
}