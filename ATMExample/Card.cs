using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMExample
{
    /*
     *  Class the represents the Card Object
     */
    public class Card
    {
        public string PAN { get; set; }
        public string expDate { get; set; }
        public int CVV { get; set; }

        public Card(string PAN, string expDate, int CVV) 
        {
            this.PAN = PAN;
            this.expDate = expDate;
            this.CVV = CVV;
        }




    }
}
