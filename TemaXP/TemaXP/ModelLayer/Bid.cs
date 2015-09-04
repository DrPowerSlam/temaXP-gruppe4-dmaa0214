using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemaXP.ModelLayer
{
    public class Bid
    {
        public int ID { get; set; }
        public int HighestBid { get; set; }
        public Member Member { get; set; }
    }
}
