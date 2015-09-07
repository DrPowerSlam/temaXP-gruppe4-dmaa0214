using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemaXP.CtrLayer;
using TemaXP.ModelLayer;

namespace Tests
{
    [TestClass]
    public class ItemTest
    {
        private ItemCtr ctr;
        private Item Item;

        
        [TestInitialize]
        public void ItemInitialize()
        {
            ctr = new ItemCtr();

            Item = new Item()
            {
                Number = 1234,
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
        public void ItemCleanUp()
        {
            ctr = null;
            Item = null;
        }

        [TestMethod]
        public void CreateFindItem()
        {
            ctr.InsertItem(Item);
            Item foundItem = ctr.FindItem(Item.ID);
            Assert.AreEqual("TestTitle", foundItem.Title);
            ctr.DeleteItem(foundItem.ID);
        }
    }
}