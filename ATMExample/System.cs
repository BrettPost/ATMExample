using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMExample
{
    /*
     *  This class represents the background system in the ATM.
     *  
     *  cardValidation() - validates the card the user enters with the
     *  config file.
     *  
     *  findDate() - extracts the date from the user input for the 
     *  expiration date
     */
    internal class System
    {
        private List<Card> validCards { get; set; }
        public System()
        {
            Startup startup = new();
            validCards = startup.ValidCards;
        }

        public bool cardValidation(Card card)
        {
            foreach (Card curCard in validCards)
            {
                if (card.PAN.Equals(curCard.PAN) && card.expDate.Equals(curCard.expDate) && card.CVV == curCard.CVV)
                {
                    return true;
                }
            }
            //Console.WriteLine(settings);
            return false;
        }

        public string findDate(string userInput)
        {
            string[] date = userInput.Split('/');
            DateOnly expDate = new(Int32.Parse(date[1]), Int32.Parse(date[0]), 1);

            return expDate.ToString("MM/yy");
        }
    }
}
