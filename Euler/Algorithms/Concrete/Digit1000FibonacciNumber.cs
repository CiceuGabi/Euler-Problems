using System.Numerics;
using Euler.Algorithms.Abstract;
using Euler.Algorithms.Interface;

namespace Euler.Algorithms.Concrete;

public class Digit1000FibonacciNumber : AbstractAlgorithm, IAlgorithmic
{
    public void Run()
    {
        Console.WriteLine();
        Console.Write("Please insert your digits length: ");
        var number = GetUserNumber();
        FibNum(number);
    }

    private static void FibNum(int length)
    {
        BigInteger current = 1;
        BigInteger second = 0;
        var count = 1;
        while (current.ToString().Length < length)
        {
            var first = second;
            second = current;
            current = first + second;
            count++;
        }

        Console.WriteLine("The first Fibonacci sequence that contains {0} digits is on position {1} and the number is {2}", length, count, current);
    }
}