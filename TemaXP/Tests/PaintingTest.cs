using System;
using System.Data.Entity.Migrations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemaXP.DBLayer;
using TemaXP.ModelLayer;

namespace Tests
{
    [TestClass]
    public class PaintingTest
    {
        private DBContext con;

        [TestInitialize]
        public void PaintingInitialize()
        {
            con = new DBContext();
        }

        [TestCleanup]
        public void PaintingCleanUp()
        {
            con = null;
        }

        [TestMethod]
        public void CreatePainting()
        {
            Painting painting = new Painting()
            {
                Author = "TestAuthor",
                Description = "TestDescription",
                Image = "TestImage",
                Interval = 10,
                MinPrice = 100,
                PurchasePrice = 125,
                Sold = false,
                Title = "TestTitle",
                Year = 2005,
            };

            con.Paintings.Add(painting);
            con.SaveChanges();

            Painting foundPainting = con.Paintings.Find(painting.Id);

            Assert.AreEqual("TestTitle", foundPainting.Title);

            con.Paintings.Remove(foundPainting);
            con.SaveChanges();
        }

        [TestMethod]
        public void FindPainting()
        {
        }

    }
}
