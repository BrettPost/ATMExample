using ATMExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Microsoft.Extensions.Configuration;

namespace ATMExample
{
    /*
     *  Main driver of the dialogue and flow of the
     *  ATM Machine. 
     */
    class Program
    {   

        static void Main(string[] args)
        {
            System system = new();
            bool validated = false;

            string PAN = "";
            string expDate = "";
            int CVV = 0;
            Card myCard = new(PAN, expDate, CVV);

            // Save a credit card to the machine
            Console.WriteLine("Welcome to the ATM Service. Please insert your card!");

            while (!validated)
            {
                Console.Write("What is the 16-digit number on the front of the card: ");
                PAN = Console.ReadLine();

                Console.Write("What is the Expiration Date: ");
                expDate = system.findDate(Console.ReadLine());

                Console.Write("What is the 3-digit number on the back of the card: ");
                CVV = Int32.Parse(Console.ReadLine());

                myCard.PAN = PAN;
                myCard.expDate = expDate;
                myCard.CVV = CVV;
                validated = system.cardValidation(myCard);
                if (!validated)
                    Console.WriteLine("\n\n\nCard Declined...\n\n\n");
            }

            Console.WriteLine("\n\n\nCard Accepted...\n\n\n");
            Account account = new(myCard);

            while (true)
            {
                // Chose what to do with the card
                Console.WriteLine("\nWhat would you like to do today?");
                Console.WriteLine("1. See current funds.");
                Console.WriteLine("2. Withdraw funds");
                Console.WriteLine("3. Deposit funds\n");
                int action = Int32.Parse(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        Console.WriteLine("\n\n\n$" + account.displayFunds(myCard) + "\n\n\n");
                        break;
                    case 2:
                        Console.WriteLine(account.withdrawFunds(myCard));
                        break;
                    case 3:
                        account.depositFunds();
                        break;
                    default:
                        Console.WriteLine("Incorrect Action Selected.");
                        break;
                }
            }
            
        }

        // TODO: Maybe move this into the Card class
        
    }

}

