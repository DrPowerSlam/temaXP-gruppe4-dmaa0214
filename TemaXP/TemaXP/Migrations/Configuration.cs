namespace TemaXP.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using TemaXP.ModelLayer;

    internal sealed class Configuration : DbMigrationsConfiguration<TemaXP.DBLayer.DBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        // Rewriten -- How to debug?
        protected override void Seed(TemaXP.DBLayer.DBContext context)
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
                        Amount = 500+i,
                        Item = items[i],
                        Member = members [i],
                    });

                items.Add(
                    new Item()
                    {
                        Auction = auctions[i],
                        Author = "Van Gogh",
                        Description = "This is an image description",
                        Interval = 10,
                        MinPrice = 2000,
                        Number = 1000+i,
                        PurchasePrice = 2500,
                        Sold = false,
                        Image = null,
                        Title = "Test Item " + i,
                        Year = 1600+i,
                    });

                members.Add(
                    new Member()
                    {
                        Address = "Test Street " + i,
                        Auction = auctions[i],
                        Bids = bids,
                        CPR = "102128-112"+i,
                        City = "Test City",
                        Department = "Staff",
                        Email = "tstper" + i + "@gmail.com",
                        Name = "Test Person " + i,
                        PhoneNr = "2812842"+i,
                        Points = 1200,
                        ZipCode = 9000,
                    });

                foreach (var mem in members)
                {
                    context.Members.AddOrUpdate(m => m.CPR, mem);
                }
                foreach (var item in items)
                {
                    context.Items.AddOrUpdate(j => j.Title, item);
                }
                foreach (var bid in bids)
                {
                    context.Bids.AddOrUpdate(b => b.Amount, bid);
                }
                foreach (var auc in auctions)
                {
                    context.Auctions.AddOrUpdate(a => a.Date, auc);
                }

                context.SaveChanges();

            }

            
        }


        /*
        protected override void Seed(TemaXP.DBLayer.DBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data. E.g.
            //
            //context.People.AddOrUpdate(
            //  p => p.FullName,
            //  new Person { FullName = "Andrew Peters" },
            //  new Person { FullName = "Brice Lambson" },
            //  new Person { FullName = "Rowan Miller" }
            //);
            //

            //context.Art.AddOrUpdate(
            //  p => p.FullName,
            //  new Person { FullName = "Andrew Peters" },
            //  new Person { FullName = "Brice Lambson" },
            //  new Person { FullName = "Rowan Miller" }
            //);

            var items = new List<Item>
            {
                new Item
                {
                    Number = 3283,
                    Author = "Van Gogh",
                    Description = "This is the item's description",
                    Title = "TestPainting 1",
                    MinPrice = 3216,
                    Interval = 10,
                    PurchasePrice = 3500,
                    Year = 1985,
                    Sold = false,
                    Image = null,
                },
                new Item
                {
                    Number = 9877,
                    Author = "Van Gogh",
                    Description = "This is the item's description",
                    Title = "TestPainting 1",
                    MinPrice = 3216,
                    Interval = 10,
                    PurchasePrice = 3500,
                    Year = 1985,
                    Sold = false,
                    Image = null,
                },
                new Item
                {
                    Number = 5954,
                    Author = "Van Gogh",
                    Description = "This is the item's description",
                    Title = "TestPainting 1",
                    MinPrice = 3216,
                    Interval = 10,
                    PurchasePrice = 3500,
                    Year = 1985,
                    Sold = false,
                    Image = null,
                },
                new Item
                {
                    Number = 7265,
                    Author = "Van Gogh",
                    Description = "This is the item's description",
                    Title = "TestPainting 1",
                    MinPrice = 3216,
                    Interval = 10,
                    PurchasePrice = 3500,
                    Year = 1985,
                    Sold = false,
                    Image = null,
                },
            };

            var members = new List<Member>
            {
                new Member
                {
                    Address = "Testvej 1",
                    CPR = "126283-2642",
                    City = "TestCity",
                    Email = "test@test.com",
                    Name = "TestPerson 2",
                    PhoneNr = "73659285",
                    ZipCode = 9000,
                    Department = "Staff",
                    Points = 1200,
                },
                new Member
                {
                    Address = "Testvej 2",
                    CPR = "126283-8273",
                    City = "TestCity",
                    Email = "test@test.com",
                    Name = "TestPerson 2",
                    PhoneNr = "82746428",
                    ZipCode = 9000,
                    Department = "Staff",
                    Points = 1200,
                },
                new Member
                {
                    Address = "Testvej 3",
                    CPR = "126283-1638",
                    City = "TestCity",
                    Email = "test@test.com",
                    Name = "TestPerson 3",
                    PhoneNr = "82742021",
                    ZipCode = 9000,
                    Department = "Staff",
                    Points = 1200,
                },
            };

            var auctions = new List<Auction>
            {
                new Auction
                {
                    Date = DateTime.Now,
                    Members = members,
                    Items = items
                },
                //new Auction
                //{
                //    Date = DateTime.MinValue.AddDays(300),
                //    Members = members,
                //    Items = items
                //},
            };

            var bids = new List<Bid>
            {
                new Bid {Amount = 261, Member = members[0]},
                new Bid {Amount = 290, Member = members[1]},
                new Bid {Amount = 320, Member = members[2]},
            };

            //

            foreach (var mem in members)
            {
                mem.Auction = auctions[0];
                //mem.Bids = bids;
            }

            foreach (var item in items)
            {
                item.Auction = auctions[0];
            }

            //

            foreach (var member in members)
            {
                context.Members.AddOrUpdate(
                m => m.CPR,
                member
                );
            }

            foreach (var item in items)
            {
                context.Items.AddOrUpdate(
                i => i.Number,
                item
                );
            }

            foreach (var bid in bids)
            {
                context.Bids.AddOrUpdate(
                b => b.Amount,
                bid
                );
            }

            foreach (var auction in auctions)
            {
                context.Auctions.AddOrUpdate(
                a => a.ID,
                auction
                );
            }

            context.SaveChanges();
        }
        */

    }
}