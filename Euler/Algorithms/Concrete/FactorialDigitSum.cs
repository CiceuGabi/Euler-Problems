using System.Numerics;
using Euler.Algorithms.Abstract;
using Euler.Algorithms.Interface;

namespace Euler.Algorithms.Concrete;

public class FactorialDigitSum : AbstractAlgorithm, IAlgorithmic
{
    public void Run()
    {
        Console.WriteLine();
        Console.Write("Enter a number between 0 and 7000: ");
        var user = GetUserNumber();
        while (user is > 7000 or < 0)
        {
            Console.Write("Number must be between 0 and 7000. Try again: ");
            user = GetUserNumber();
        }

        Console.WriteLine();
        var result = Factorial(user).ToString();
        Console.WriteLine("Your number factorial is: " + result);
        char[] cArr = result.ToCharArray();
        BigInteger sum = 0;
        foreach (var item in cArr)
        {
            var number = item - '0';
            sum += number;
        }

        Console.WriteLine("The sum of the digits in the number {0}! is {1}", user, sum);
    }

    private static BigInteger Factorial(int num)
    {
        if (num is 1 or 0)
        {
            return 1;
        }

        return num * Factorial(num - 1);
    }
}