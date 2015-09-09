using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using TemaXP.ModelLayer;

namespace KunstklubAdmin
{
    public class NextItemChangedArgs : EventArgs
    {
        public Item Item { get; set; }

        public NextItemChangedArgs(Item item)
        {
            this.Item = item;
        }
    }
}
