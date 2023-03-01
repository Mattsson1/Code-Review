using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion_5
{
    internal class MeraLinqExercises
    {
        public void Run2()
        {
            var upperCaseWords = "Input the string : this IS a STRING Expected Output : The UPPER CASE words are : IS STRING";

           // upperCaseWords.ToCharArray().Where(s => char.IsUpper(s)).ToList().ForEach(c => Console.WriteLine(c));

           /* var upperCases2 = upperCaseWords.Split('\u0020', StringSplitOptions.RemoveEmptyEntries).Where(e => e == e.ToUpper());
       
            foreach(var upperCase in upperCases2)
            {
                Console.WriteLine(upperCase);
            }
           */
            var upperCase3 = upperCaseWords.Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(e => e == e.ToUpper());

            foreach( var upperCase2 in upperCase3)
            {
                Console.Write(upperCase2);
            }

            Console.WriteLine();
        }
        
        public void Run3()
        {
            string[] cities =
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
            };

            var sorted = cities.OrderBy(e => e).OrderBy(e => e.Length);

            foreach(var s in sorted)
            {
                Console.WriteLine(s);
            }
        }

        public void Run4()
        {
            List<Customer> customers = new List<Customer>() {
                new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
                new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
                new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
                new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
                new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
                new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
                new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
                new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
                new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
                new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };

            

        }
    }
    public class Customer
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Bank { get; set; }

    }

}
