using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaXP.ModelLayer
{
    public class Member
    {
        public String Name { get; set; }
        public String Department { get; set; }
        public String CPR { get; set; }
        public String Address { get; set; }
        public int ZipCode { get; set; }
        public String City { get; set; }
        public String Email { get; set; }
        public String PhoneNr { get; set; }
        public int Points { get; set; }

        public Bid CurrentBid { get; set; }
        
        // bool admin? 

    }
}
