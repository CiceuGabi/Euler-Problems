using Euler.Algorithms.Interface;

namespace Euler.Algorithms.Concrete;

public class SpecialPythagoreanTriplet : IAlgorithmic
{
    public void Run()
    {
        Console.WriteLine();
        int sum = 1000;

        for (int i = 1; i < sum; i++)
        {
            for (int j = i + 1; j < sum; j++)
            {
                int c = sum - i - j;
                var firstResult = i * i + j * j;
                var result = c * c;
                if (firstResult == result)
                {
                    Console.WriteLine("The Pythagorean triplet of which the sum is 1000 is: " + i + " + " + j + " + " + c);
                    Console.WriteLine("And the product between these numbers is: " + i * j * c);
                }
            }
        }
    }
}