using System.Collections.Generic;
using System.Linq;
using TemaXP.ModelLayer;

namespace TemaXP.DBLayer
{
    public class ItemRepository : SuperRepository
    {
        public void InsertItem(Item Item)
        {
            context.Items.Add(Item);
            Save();
        }

        public Item FindItem(int id)
        {
            return context.Items.Find(id);
        }

        public void DeleteItem(int id)
        {
            context.Items.Remove(FindItem(id));
            Save();
        }

        public List<Item> GetAllItems()
        {
            return context.Items.ToList();
        }
    }
}