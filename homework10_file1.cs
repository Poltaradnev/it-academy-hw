using System;

namespace homework10_File1.
class Program
{
    static void Main(string[] args)
    { 
        Console.WriteLine($"{DisplayPartOfDay()} Welcome to the airport!\n");
        Console.Write("Enter your first name last name and passport number :\nFirst name: ");
        string FirstName = Console.ReadLine();
        Console.Write("Last name: ");
        string LastName = Console.ReadLine();
        Console.Write("Passport number: ");
        string PassportNumber = Console.ReadLine();
        Passanger passanger = new Passanger(FirstName, LastName, PassportNumber);
        Console.Clear();

        Console.WriteLine("If you have a ticket and want to print it press to(P), enter 'p' to print them");
        Console.WriteLine("If you need to buy ticket(s), enter 'b'");
        char registrationChoice = Convert.ToChar(Console.ReadLine());

        switch (registrationChoice)
        {
            case 'p':
                Console.WriteLine("Please, give your passport (press 1 to give passport)");
                char choice = Convert.ToChar(Console.ReadLine());
                if (choice == 'p')
                {
                    Console.WriteLine("In order for us to check if your information is correct, enter next information:");
                    Console.Write("Your destination: ");
                    string FlightDestination = Console.ReadLine();
                    Console.Write("Quantity of tickets: ");
                    byte NumberOfPassangers = Convert.ToByte(Console.ReadLine());
                    Random random = new Random();
                    int TicketPrice = random.Next(100, 1000);
                    int FlightNumber = random.Next(1000);
                    DateTime DepartureTime = new DateTime();
                    DepartureTime = DateTime.Now.AddMinutes(random.Next(60));
                    Ticket ticket = new Ticket(DepartureTime, FlightDestination, FlightNumber, NumberOfPassangers, TicketPrice);
                    Console.Clear();
                    Console.WriteLine("Please, check info below and press any key to move to security control");
                    ticket.DisplayTicketsInfo();
                }
                else
                {
                    Console.WriteLine("Invalid data");
                }
                break;

            case 'b':
                Console.Write("Please, enter your destination: ");
                string flightDestination = Console.ReadLine();
                Console.Write("Quantity of tickets: ");
                byte numberOfPassangers = Convert.ToByte(Console.ReadLine());
                Random random2 = new Random();
                int ticketPrice = random2.Next(150, 2000);
                int flightNumber = random2.Next(2000);
                DateTime departureTime = new DateTime();
                departureTime = DateTime.Now.AddMinutes(random2.Next(60));
                Ticket ticket2 = new Ticket(departureTime, flightDestination, flightNumber, numberOfPassangers, ticketPrice);

                if (ticket2.PurchaiseTickets() == true)
                {
                    Console.Clear();
                    Console.WriteLine("Processing...\nTransaction successful go to print ticket");
                    ticket2.DisplayTicketsInfo();
                }
                else
                {
                    Console.WriteLine("Unfortunately, the operation was not performed, try again, or contact the administrator");
                    Environment.Exit(0);
                }
                break;

            default:
                break;
        }
        Console.ReadKey();
        Console.Clear();    
               

        Console.WriteLine("Passport control\nPlease, give your passport (press any key)");
        Console.ReadKey();
        Console.WriteLine("Processing...\nPassport control is OK. Have a nice flight!");
        Console.ReadLine();
    }

    public static string DisplayPartOfDay()
    {
        int hour = DateTime.Now.Hour;

        if ((hour >= 9) && (hour < 12))
            return "GOOD MORNING!";
        else if ((hour >= 12) && (hour < 18))
            return "GOOD AFTERNOON!";
        else
            return "GOOD EVENING!";
    }
}
}