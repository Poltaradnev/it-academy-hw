using System;
namespace homework10_File2
{
    public class Ticket
    {
        public DateTime flightDepartureTime;
        public string flightDestination;
        public int flightNumber;
        public byte numberOfPassangers;
        public int ticketPrice;

        public bool PurchaiseTickets()
        {
            Console.WriteLine($"{this.numberOfPassangers} ticket(s) to flight #{this.flightNumber} from Minsk to {this.flightDestination} departure {this.flightDepartureTime} is ${this.ticketPrice * this.numberOfPassangers}\nAre you ready to purchaise? (yes/no)");
            string choice = Console.ReadLine();

            bool isTicketPaid = false;

            switch (choice)
            {
                case "yes":
                    isTicketPaid = true;
                    break;

                case "no":
                    isTicketPaid = false;
                    break;

                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }
            return isTicketPaid;
        }

        public void DisplayTicketsInfo()
        {
            Console.WriteLine($"Fligh #{this.flightNumber}");
            Console.WriteLine($"Flight destination: {this.flightDestination}");
            Console.WriteLine($"Departure time: {this.flightDepartureTime}");
            Console.WriteLine($"{this.numberOfPassangers} tickets");
            Console.WriteLine($"Total price: ${this.ticketPrice * this.numberOfPassangers}");
        }

        public Ticket() { }

        public Ticket(DateTime flightDepartureTime, string flightDestination, int flightNumber, byte numberOfPassangers, int ticketPrice)
        {
            this.flightDepartureTime = flightDepartureTime;
            this.flightDestination = flightDestination;
            this.flightNumber = flightNumber;
            this.numberOfPassangers = numberOfPassangers;
            this.ticketPrice = ticketPrice;
        }
    }
}