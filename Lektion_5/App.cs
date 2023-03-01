using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lektion_5
{
    internal class App
    {
        public int RabbatPercent()
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
                return 10;
            return 0;
        }

        public void Run()
        {

            var annons = new//Vi kan inte ändra värde på anonyma objekt
            {
                Seller = "Stefan H",
                Title = "Playstation 5",
                Description = "Nästan oanvänd",
                Price = 100,
                Created = DateTime.Now,
                EndDate = DateTime.Today.AddDays(30),
                Rabatt = RabbatPercent(),
                Bids = new[]
                {
                    new
                    {
                       Name = "Kalle",
                       Date = new DateTime(2022,11,05,22,25,12),
                       Price = 2100

                    },
                    new
                    {
                        Name = "Lisa",
                        Date = new DateTime(2022,11,6,09,55,12),
                        Price = 2200
                    }
                }
                //Bids = new List<Object> { { Name = "Kalle", DateTime = new DateTime(2022 - 11 - 05), Price = 2100 } }
                };

                foreach (var annon in annons.Bids)
                  {
                    //borde stå console.WriteLine(annon); tycker jag :)
                     Console.WriteLine($"{annon.Name} {annon.Price} {annon.Date}");
                  }
                
                while (true) 
            {
                Console.WriteLine("lollollollollollollollollollollollollollollollollollollollollollollollollollollollollollollollollollollol");
            }


        }
    }
}
