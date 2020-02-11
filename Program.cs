using System;

namespace Cups_of_coffee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NumberOfCupsOfCoffee");
            var fullName = "Robbie Nieman";
            var today = "2/10/20";
            Console.WriteLine("NumberOfCupsOfCoffee " + fullName + " " + today);
            Console.WriteLine("Hello, What's Your Name");
            var user = Console.ReadLine();
            Console.WriteLine("Choose a number between 1 and 5");
            var firstNumber = Console.ReadLine();
            var operand1 = double.Parse(firstNumber);
            Console.WriteLine("Choose a number between 5 and 10");
            var secondNumber = Console.ReadLine();
            var operand2 = double.Parse(secondNumber);
            // Store Operations
            var sum = operand1 + operand2;
            var difference = operand2 - operand1;
            var quotient = operand2 / operand1;
            var product = operand1 * operand2;
            var remainder = operand1 % operand2;
            Console.WriteLine("Coffee Sum" + " " + sum);
            Console.WriteLine("Coffee Difference" + " " + difference);
            Console.WriteLine("Coffee Quotient" + " " + quotient);
            Console.WriteLine("Coffee Product" + " " + product);
            Console.WriteLine("Coffee Remainder" + " " + remainder);














        }
    }
}
