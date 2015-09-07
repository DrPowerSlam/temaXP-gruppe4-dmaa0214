using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TemaXP.CtrLayer;
using TemaXP.ModelLayer;

namespace Tests
{
    [TestClass]
    public class AuctionTest
    {
        private AuctionCtr ctr;
        private Auction auction;

        [TestInitialize]
        public void AuctionInitialize()
        {
            ctr = new AuctionCtr();

            List<Member> members = new List<Member>()
            {
                new Member(),
                new Member(),
            };

            List<Item> Items = new List<Item>()
            {
                new Item () {Number = 1245},
                new Item () {Number = 1246},
            };

            auction = new Auction()
            {
                Date = DateTime.Now,
                //Members = members,
                //Items = Items
            };
        }

        [TestCleanup]
        public void AuctionCleanUp()
        {
            ctr = null;
            auction = null;
        }

        [TestMethod]
        public void CreateFindAuction()
        {
            ctr.InsertAuction(auction);
            Auction foundAuction = ctr.FindAuction(auction.ID);
            Assert.AreEqual(auction.ID, foundAuction.ID);
            ctr.DeleteAuction(foundAuction.ID);
        }


    }
}
