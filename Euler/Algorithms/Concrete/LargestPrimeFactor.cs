using Euler.Algorithms.Abstract;
using Euler.Algorithms.Interface;

namespace Euler.Algorithms.Concrete;

public class LargestPrimeFactor : AbstractAlgorithm, IAlgorithmic
{
    public void Run()
    {
        Console.WriteLine();
        Console.Write("Enter your number: ");
        var inputNumber = GetUserNumber();
        long maxPrime = 0;
        long number = inputNumber;

        if (inputNumber % 2 == 0)
        {
            maxPrime = 2;
        }

        while (inputNumber % 2 == 0)
        {
            inputNumber /= 2;
        }

        for (int i = 3; i < Math.Sqrt(inputNumber); i += 2)
        {
            while (inputNumber % i == 0)
            {
                maxPrime = i;
                inputNumber /= i;
            }
        }

        if (inputNumber > 2)
        {
            maxPrime = inputNumber;
        }

        Console.WriteLine("Max prime of {0}, is {1}",number, maxPrime);
    }
}