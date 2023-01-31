using Euler.Algorithms.Abstract;
using Euler.Algorithms.Interface;

namespace Euler.Algorithms.Concrete;

public class HighlyDivisibleTriangularNumber : AbstractAlgorithm, IAlgorithmic
{
    public void Run()
    {
        long sum = 0;

        for (int i = 1; i < int.MaxValue; i++)
        {
            sum += i;
            var count = 0;
            for (int j = 1; j < Math.Sqrt(sum); j++)
            {
                if (sum % j == 0)
                {
                    count += 2;
                }

                if (count == 500)
                {
                    Console.WriteLine("The number is:" + sum);
                    return;
                }
            }
        }
    }
}