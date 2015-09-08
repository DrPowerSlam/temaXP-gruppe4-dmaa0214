using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using TemaXP.ModelLayer;

namespace TemaXP
{
    public class Program
    {
        public static void Main(String[] args)
        {
            var auctions = new List<Auction>();
            var bids = new List<Bid>();
            var items = new List<Item>();
            var members = new List<Member>();

            for (int i = 0; i < 3; i++)
            {
                auctions.Add(
                    new Auction()
                    {
                        Members = members,
                        Date = DateTime.Now,
                        Items = items,
                    });

                bids.Add(
                    new Bid()
                    {
                        Amount = 500 + i,
                        Item = items[i],
                        Member = members[i],
                    });

                items.Add(
                    new Item()
                    {
                        Auction = auctions[i],
                        Author = "Van Gogh",
                        Description = "This is an image description",
                        Interval = 10,
                        MinPrice = 2000,
                        Number = 1000 + i,
                        PurchasePrice = 2500,
                        Sold = false,
                        Image = null,
                        Title = "Test Item " + i,
                        Year = 1600 + i,
                    });

                members.Add(
                    new Member()
                    {
                        Address = "Test Street " + i,
                        Auction = auctions[i],
                        Bids = bids,
                        CPR = "102128-112" + i,
                        City = "Test City",
                        Department = "Staff",
                        Email = "tstper" + i + "@gmail.com",
                        Name = "Test Person " + i,
                        PhoneNr = "2812842" + i,
                        Points = 1200,
                        ZipCode = 9000,
                    });
            }
        }
    }
}
