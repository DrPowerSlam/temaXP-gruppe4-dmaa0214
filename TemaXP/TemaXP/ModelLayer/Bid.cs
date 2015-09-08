using System;
using System.ComponentModel.DataAnnotations;

namespace TemaXP.ModelLayer
{
    public class Bid
    {
        public int ID { get; set; }
        public int Amount { get; set; }
        public Member Member { get; set; }
        public Item Item { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }
}