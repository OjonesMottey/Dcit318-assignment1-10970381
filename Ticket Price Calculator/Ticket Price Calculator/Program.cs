using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constants for ticket prices
            const decimal REGULAR_PRICE = 10.00m;
            const decimal DISCOUNTED_PRICE = 7.00m;

            // Prompt user for age
            Console.Write("Please enter your age: ");
            string input = Console.ReadLine();

            // Parse input to integer
            int age;
            if (int.TryParse(input, out age))
            {
                // Calculate ticket price based on age
                decimal ticketPrice = (age <= 12 || age >= 65) ? DISCOUNTED_PRICE : REGULAR_PRICE;

                // Display the ticket price
                Console.WriteLine("Your ticket price is: GHC" + ticketPrice);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }

            // Keep console window open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}