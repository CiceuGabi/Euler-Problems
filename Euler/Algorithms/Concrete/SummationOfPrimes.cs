using Euler.Algorithms.Abstract;
using Euler.Algorithms.Interface;

namespace Euler.Algorithms.Concrete;

public class SummationOfPrimes : AbstractAlgorithm, IAlgorithmic
{
    public void Run()
    {
        Console.WriteLine();
        Console.Write("Enter a number to find the sum of the primes below it: ");
        var number = GetUserNumber();
        long sum = 0;
        for (int i = 1; i < number; i++)
        {
            if (IsPrime(i))
            {
                sum += i;
            }
        }

        Console.WriteLine("Sum is: " + sum);
    }


    public static void Summation(int inputNumber)
    {
        long sum = 0;

        var arrayToSum = new List<int>();

        for (int i = 0; i < inputNumber; i++)
        {
            arrayToSum.Add(i);
        }

        for (int i = 2; i < inputNumber; i++)
        {
            if (arrayToSum[i] != 0)
            {
                for (int j = (2 * i); j < inputNumber; j += i)
                {
                    arrayToSum[j] = 0;
                }
            }
        }

        foreach (var t in arrayToSum)
        {
            if (t != 1)
            {
                sum += t;
            }
        }

        Console.WriteLine("The sum is: " + sum);
    }

    private bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        if (number == 2)
            return true;
        if (number % 2 == 0)
            return false;

        for (int i = 3; i * i <= number; i += 2)
        {
            if (number % i == 0)

                return false;
        }

        return true;
    }
}