using System;


namespace Branching_assignment
{

    public class Program

    {

        public static void Main(string[] args)

        {

            // Code will display the Welcome message

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt for the package weight

            Console.Write("Please enter the package weight: ");

            double weight;

            if (!double.TryParse(Console.ReadLine(), out weight))

            {

                Console.WriteLine("Invalid weight input. Please enter a numeric value.");

                return;

            }

            // Check weight limit

            if (weight > 50)

            {

                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");

                return;

            }

            // Get package dimensions

            Console.Write("Please enter the package width: ");

            double width;

            if (!double.TryParse(Console.ReadLine(), out width))

            {

                Console.WriteLine("Invalid width input. Please enter a numeric value.");

                return;

            }

            Console.Write("Please enter the package height: ");

            double height;

            if (!double.TryParse(Console.ReadLine(), out height))

            {

                Console.WriteLine("Invalid height input. Please enter a numeric value.");

                return;

            }

            Console.Write("Please enter the package length: ");

            double length;

            if (!double.TryParse(Console.ReadLine(), out length))

            {

                Console.WriteLine("Invalid length input. Please enter a numeric value.");

                return;

            }

            // Check dimensions limit

            double totalDimensions = width + height + length;

            if (totalDimensions > 50)

            {

                Console.WriteLine("Package too big to be shipped via Package Express.");

                return;

            }

            // Calculate quote

            double volume = height * width * length;

            double quote = (volume * weight) / 100;

            // Display quote

            Console.WriteLine($"Your estimated shipping quote is: ${quote:F2}");
            Console.ReadLine();

        }

    
    
    }
}
