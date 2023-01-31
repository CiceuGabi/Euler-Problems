using Euler.Algorithms.Abstract;
using Euler.Algorithms.Interface;

namespace Euler.Algorithms.Concrete;

public class LargestPalindromeProduct : AbstractAlgorithm, IAlgorithmic
{
    public void Run()
    {
        Console.WriteLine();
        int maxI = 0;
        int maxJ = 0;
        int maxResult = 0;
        for (int i = 900; i <= 999; i++)
        {
            for (int j = 900; j <= 999; j++)
            {
                int result = i * j;

                if (IsPalindrome(result) && maxResult < result)
                {
                    maxResult = result;
                    maxI = i;
                    maxJ = j;
                }
            }
        }

        Console.WriteLine("The multiplication between {0} x {1} result the palindrome {2}", maxI, maxJ, maxResult);
    }

    private static bool IsPalindrome(int number)
    {
        var reverse = 0;
        var actualNumber = number;

        while (number != 0)
        {
            int reminder = number % 10;
            reverse = reverse * 10 + reminder;
            number /= 10;
        }

        if (actualNumber == reverse)
        {
            return true;
        }

        return false;
    }
}