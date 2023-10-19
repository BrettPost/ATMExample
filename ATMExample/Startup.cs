using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMExample
{
    /* 
     *  Class runs when program start.
     *  
     *  Sets up configuration objects. Configuration file stores
     *  the different valid Credit Cards, and those cards are stored
     *  in ValidCards.
     *  
     */
    public class Startup
    {
        public Startup()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            IConfiguration config = builder.Build();

            ValidCards = config.GetSection("Settings:Cards").Get<List<Card>>();

        }

        public List<Card> ValidCards { get; set; }
    }
}
