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
            Console.WriteLine("Zoo Expenses: ");
            Console.WriteLine();
            TicketPrices();
            SouvenirPrices();
            ParkingCost();
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
            Console.WriteLine();
        }
        
        static void ParkingCost()
        {
            Lot parkingLot = new Lot();
            Garage parkingGarage = new Garage();

            Console.WriteLine();
            Console.WriteLine("PARKING");
            Console.Write("  Parking Lot: $");
            Console.Write(parkingLot.Price());
            Console.WriteLine();
            Console.Write("  Parking Garage: $");
            Console.Write(parkingGarage.Price());
        }

    }
}
