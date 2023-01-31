using Euler.Algorithms.Abstract;
using Euler.Algorithms.Interface;

namespace Euler.Algorithms.Concrete;

public class SmallestMultiple : AbstractAlgorithm, IAlgorithmic
{
    public void Run()
    {
        Console.WriteLine();
        Console.Write("Please enter the las number to divide with: ");
        var n = GetUserNumber();
        var watch = new System.Diagnostics.Stopwatch();
        watch.Start();
        Console.WriteLine("This is fast");
        long ans = 1;
        for (long i = 1; i <= n; i++)
        {
            ans = (ans * i) / (Gcd(ans, i));
        }

        watch.Stop();
        Console.WriteLine(watch.Elapsed);
        Console.WriteLine("The smallest positive number is: " + ans);
    }

    public void Smallest(int num)
    {
        var watch = new System.Diagnostics.Stopwatch();
        watch.Start();
        Console.WriteLine("This will take a while. Go drink a glass of water is good to be hydrated");
        long firstNum = int.MaxValue;
        long i;
        for (i = 1; i < int.MaxValue; i++)
        {
            long j;
            for (j = 1; j <= num; j++)
            {
                if (i % j != 0)
                {
                    break;
                }

                if (j == num && firstNum > i)
                {
                    firstNum = i;
                }
            }
        }

        watch.Stop();
        Console.WriteLine("I told you it will be slow AF");
        Console.WriteLine(watch.Elapsed);
        Console.WriteLine("The smallest positive number is: " + firstNum);
    }

    private static long Gcd(long a, long b)
    {
        if (a % b != 0)
        {
            return Gcd(b, a % b);
        }

        return b;
    }

    public void Lcm1(long n)
    {
        long ans = 1;
        for (long i = 1; i <= n; i++)
        {
            ans = (ans * i) / (Gcd(ans, i));
        }

        Console.WriteLine("The smallest positive number is: " + ans);
    }
}