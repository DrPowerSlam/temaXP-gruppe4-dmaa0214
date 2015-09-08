using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TemaXP.ModelLayer
{
    public class Bid
    {
        public int ID { get; set; }
        public int Amount { get; set; }

        [ForeignKey("Member")]
        public int MemberID { get; set; }
        public Member Member { get; set; }

        [ForeignKey("Item")]
        public int ItemID { get; set; }
        public Item Item { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }
}