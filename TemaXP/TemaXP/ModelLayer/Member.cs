using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TemaXP.ModelLayer
{
    public class Member
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public String Name { get; set; }
        public String Department { get; set; }
        public String CPR { get; set; }
        public String Address { get; set; }
        public int ZipCode { get; set; }
        public String City { get; set; }
        public String Email { get; set; }
        public String PhoneNr { get; set; }

        //ik mere end 5 års kontigent i points. 50(om måneden)*12(1 år)*5(5 år)
        public int Points { get; set; }

        public List<Bid> Bids { get; set; }

        [ForeignKey("Auction")]
        public int? AuctionID { get; set; }
        public Auction Auction { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }

        // bool admin?


    }
}