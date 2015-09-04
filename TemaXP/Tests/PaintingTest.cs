using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemaXP.CtrLayer;
using TemaXP.ModelLayer;

namespace Tests
{
    [TestClass]
    public class PaintingTest
    {
        private PaintingCtr ctr;
        private Painting painting;

        //TODO nummer skal være firechifret nummer...
        [TestInitialize]
        public void PaintingInitialize()
        {
            ctr = new PaintingCtr();

            painting = new Painting()
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
        }

        [TestCleanup]
        public void PaintingCleanUp()
        {
            ctr = null;
            painting = null;
        }

        [TestMethod]
        public void CreateFindPainting()
        {
            ctr.InsertPainting(painting);
            Painting foundPainting = ctr.FindPainting(painting.ID);
            Assert.AreEqual("TestTitle", foundPainting.Title);
            ctr.DeletePainting(foundPainting.ID);
        }
    }
}