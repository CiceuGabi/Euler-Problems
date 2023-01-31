using Euler.Factory;

namespace Euler.Root;

public class Program
{
    public static void Main(string[] args)
    {
        PrintMenu();
    }

    private static void PrintMenu()
    {
        var algorithmicFactory = new AlgorithmicFactory();
        Console.WriteLine();
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Hi there! This is the main menu:");
        Console.WriteLine("Press -1- if you want to find the sum of multiples of 3 or 5 of your number");
        Console.WriteLine("Press -2- if you want to find the sum of the even numbers of the Fibonacci sequence whose values do not exceed a limit that you impose");
        Console.WriteLine("Press -3- if you want to find the largest prime factor of your number");
        Console.WriteLine("Press -4- if you want to find the largest palindrome made from the product of two 3-digit numbers");
        Console.WriteLine("Press -5- if you want to find the smallest positive number that is evenly divisible by all the numbers from 1 to a number that you impose");
        Console.WriteLine("Press -6- if you want to find the difference between the sum of the squares and the square of the sum of the first x numbers that you impose");
        Console.WriteLine("Press -7- if you want to find the prime number on the position specified by you");
        Console.WriteLine("Press -8- if you want to find the product of how long you want adjacent digits of a 1000-digit number ");
        Console.WriteLine("Press -9- if you want to find the product a * b * c of Pythagorean triplet for which a + b + c = 1000");
        Console.WriteLine("Press -10- if you want to find the sum of the primes number below a specified number");
        Console.WriteLine("Press -11- if you want to find the digits sum of a number raised at the power you choose");
        Console.WriteLine("Press -12- if you want to find the first ten digits from the sum of one hundred 50 digit number");
        Console.WriteLine("Press -13- if you want to find the first triangle number that have 500 divisors");
        Console.WriteLine("Press -14- if you want to find the letters count from 1 to your input number");
        Console.WriteLine("Press -15- if you want to find the sum of the digits from a number factorial that you inserted");
        Console.WriteLine("Press -16- if you want to find the index of the first term in the Fibonacci sequence to contain how many digits you want");
        Console.WriteLine("Press -0- if you want to exit the program");
        Console.WriteLine();
        Console.Write("Your answer: ");
        var createdAlgorithmic = algorithmicFactory.Create(SwitchUserInputAndValidation());
        createdAlgorithmic.Run();
        MakeDecision();
    }


    private static void MakeDecision()
    {
        var decisionList = new List<string> { "x", "y" };
        Console.WriteLine();
        Console.Write("If you want to go to main menu press 'y' or if you want to exit the program press 'x': ");
        var userDecision = Console.ReadLine();
        while (!decisionList.Contains(userDecision))
        {
            Console.Write("This is not a valid response. You can use only 'y' or 'x'. Please enter a valid input: ");
            userDecision = Console.ReadLine();
        }

        if (userDecision.Equals("y"))
        {
            PrintMenu();
        }
        else
        {
            Console.WriteLine("Exiting the program...");
        }
    }

    private static int SwitchUserInputAndValidation()
    {
        while (true)
        {
            var input = Console.ReadLine();

            if (int.TryParse(input, out var num))
            {
                if (num is >= 0 and <= 16)
                {
                    return num;
                }

                Console.Write("Number must be between 1-16: ");
            }
            else
            {
                Console.Write("This is not a number. Enter a valid number: ");
            }
        }
    }
}