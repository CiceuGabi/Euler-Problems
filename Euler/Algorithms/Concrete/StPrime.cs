using Euler.Algorithms.Abstract;
using Euler.Algorithms.Interface;

namespace Euler.Algorithms.Concrete;

public class StPrime : AbstractAlgorithm, IAlgorithmic
{
    public void Run()
    {
        Console.WriteLine();
        Console.Write("Please enter the position from which you want to find the prime number: ");
        var num = GetUserNumber(); 
        long i;
        int count = 0;
        for (i = 2; i <= long.MaxValue; i++)
        {
            if (IsPrime(i))
            {
                count++;
            }

            if (count == num)
            {
                Console.WriteLine("The prime number on the position {0} is: {1}", num, i);
                break;
            }
        }
    }
    

    private bool IsPrime(long number)
    {
        for (long i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}