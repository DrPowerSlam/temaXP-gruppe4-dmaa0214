using System;
using System.Collections.Generic;

namespace TemaXP.ModelLayer
{
    public class Auction
    {
        public int ID { get; set; }
        public List<Painting> Paintings { get; set; }
        public List<Member> Members { get; set; }
        public DateTime Date { get; set; }
    }
}