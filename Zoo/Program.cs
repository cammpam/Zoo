using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Program : Zoo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zoo Fees: ");
            Console.WriteLine();
            TicketPrices();
            Console.Read();
        }

        static void TicketPrices()
        {
            Console.WriteLine("TICKETS");
            AdultTicket regular = new AdultTicket();
            KidsTicket oneKid = new KidsTicket();
            SeniorTicket oneSenior = new SeniorTicket();

            Console.Write("  Adults: $");
            Console.Write(regular.Price());
            Console.WriteLine();
            Console.Write("  Kids: $");
            Console.Write(oneKid.Price());
            Console.WriteLine();
            Console.Write("  Senior: $");
            Console.Write(oneSenior.Price());
        }
      
    }
}
