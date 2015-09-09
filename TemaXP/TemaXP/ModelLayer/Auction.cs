using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TemaXP.ModelLayer
{
    public class Auction
    {
        public int ID { get; set; }
        public List<Item> Items { get; set; }
        public List<Member> Members { get; set; }
        [Required]
        public DateTime Date { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }
}