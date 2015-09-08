using System;
using System.ComponentModel.DataAnnotations;

namespace TemaXP.ModelLayer
{
    public class Bid
    {
        public int ID { get; set; }
        public int HighestBid { get; set; }
        public Member Member { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }
}