using Euler.Algorithms.Abstract;
using Euler.Algorithms.Interface;

namespace Euler.Algorithms.Concrete;

public class MultiplesOf3Or5 : AbstractAlgorithm, IAlgorithmic
{
    public void Run()
    {
        
        Console.WriteLine();
        Console.Write("Please enter a number: ");
        var number = GetUserNumber();
        var multiples = new List<int>();
        var sum = 0;
        for
            (int i = 1; i < number; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
                multiples.Add(i);
            }
        }

        Console.Write("Your number multiples of 3 or 5 are: ");
        foreach (var mul in multiples)
        {
            Console.Write(mul + " ");
        }

        Console.WriteLine();
        Console.WriteLine("Sum of the multiples is: " + sum);
    }
}