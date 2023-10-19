using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMExample
{
    /*
     *  This class represents the profile a
     *  user gets with a validated card.
     *  
     *  displayFunds() - shows current balance
     *  
     *  withdrawFunds() - TODO: removes money from savings
     *  
     *  depositFunds() - adds money to savings
     */
    internal class Account
    {
        private Card card;
        private double savings = 0.00;

        public Account(Card card) 
        {
            this.card = card;
        }

        public double displayFunds(Card card)
        {
            if (card == this.card)
            {
                return savings;
            }
            
            return 0.00;
        }

        public double withdrawFunds(Card card)
        {
            double amount = 0;
            return amount;
        }

        public double depositFunds()
        {
            try
            {
                Console.WriteLine("How much would you like to deposit?");
                savings += Convert.ToDouble(Console.ReadLine());
            } catch
            {
                Console.WriteLine("Invalid...");
            }

            return savings;
        }
    }
}
