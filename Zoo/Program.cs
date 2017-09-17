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
            SouvenirPrices();
            Console.Read();
        }

        static void TicketPrices()
        {
            AdultTicket regular = new AdultTicket();
            KidsTicket oneKid = new KidsTicket();
            SeniorTicket oneSenior = new SeniorTicket();

            Console.WriteLine("TICKETS");

            Console.Write("  Adults: $");
            Console.Write(regular.Price());
            Console.WriteLine();
            Console.Write("  Kids: $");
            Console.Write(oneKid.Price());
            Console.WriteLine();
            Console.Write("  Senior: $");
            Console.Write(oneSenior.Price());
            Console.WriteLine();
        }

        static void SouvenirPrices()
        {
            PhotoWithLion onePhoto = new PhotoWithLion();
            StuffedAnimal eachAnimal = new StuffedAnimal();
            


            Console.WriteLine();
            Console.WriteLine("SOUVENIRS");
            Console.Write("  Photo with a Lion: $");
            Console.Write(onePhoto.Price());
            Console.WriteLine();
            Console.Write("    Latest review: ");
            Console.Write(onePhoto.ProductReview());
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("  Stuffed Animal: $");
            Console.Write(eachAnimal.Price());
            Console.WriteLine();
            Console.Write("    Latest review: ");
            Console.Write(eachAnimal.ProductReview());
        }

    }
}
