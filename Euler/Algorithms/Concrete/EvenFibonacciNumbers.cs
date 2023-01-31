using Euler.Algorithms.Abstract;
using Euler.Algorithms.Interface;

namespace Euler.Algorithms.Concrete;

public class EvenFibonacciNumbers : AbstractAlgorithm, IAlgorithmic
{
    public void Run()
    {
        Console.WriteLine();
        Console.Write("Enter your limit:");
        var inputNumber = GetUserNumber();
        var second = 0;
        var current = 1;
        var sum = 0;
        var fibSeq = new List<int>();
        var evenFibNo = new List<int>();

        while (current < inputNumber)
        {
            if (current % 2 == 0)
            {
                sum += current;
                evenFibNo.Add(current);
            }

            fibSeq.Add(current);
            var first = second;
            second = current;
            current = first + second;
        }

        Console.Write("The Fibonacci sequence of your limit is: ");
        foreach (var fibNo in fibSeq)
        {
            Console.Write(fibNo + " ");
        }

        Console.WriteLine();
        Console.Write("The even numbers from the Fibonacci sequence are: ");
        foreach (var number in evenFibNo)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();
        Console.WriteLine("The sum of the even numbers is: " + sum);
    }
}