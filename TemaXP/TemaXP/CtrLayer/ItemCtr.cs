using System;
using System.Collections.Generic;
using TemaXP.DBLayer;
using TemaXP.ModelLayer;

namespace TemaXP.CtrLayer
{
    public class ItemCtr
    {
        private ItemRepository repos;

        public ItemCtr()
        {
            repos = new ItemRepository();
        }

        public void InsertItem(Item item)
        {
            if (item.MinPrice != 0 && item.Interval == 0)
            {
                item.Interval = Convert.ToInt32(item.MinPrice * 0.1);
            }

            repos.InsertItem(item);
        }

        public Item FindItem(int id)
        {
            return repos.FindItem(id);
        }

        public List<Item> GetAllItems()
        {
            return repos.GetAllItems();
        }

        public void DeleteItem(int id)
        {
            repos.DeleteItem(id);
        }

        public int CalculateInterval(Item item)
        {
            return item.MinPrice * item.Interval / 100;
        }
    }
}