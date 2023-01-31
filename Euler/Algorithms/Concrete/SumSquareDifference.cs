using Euler.Algorithms.Abstract;
using Euler.Algorithms.Interface;

namespace Euler.Algorithms.Concrete;

public class SumSquareDifference : AbstractAlgorithm, IAlgorithmic
{
    public void Run()
    {
        Console.WriteLine();
        Console.Write("Please enter a number: ");
        var num = GetUserNumber();
        long sumSquare = 0;
        for (int i = 1; i <= num; i++)
        {
            long number = i * i;
            sumSquare += number;
        }

        Console.WriteLine("The sum of the squares of your number is: " +sumSquare);

        long squareSum = 0;
        for (int j = 0; j <= num; j++)
        {
            squareSum += j;
        }

        squareSum *= squareSum;
        Console.WriteLine("The square of the sum of your number is: " + squareSum);

        long result = squareSum - sumSquare;
        Console.WriteLine("The difference between the square of the sum and the sum of the squares is {0} - {1} = {2} ",squareSum, sumSquare, result);
    }

    
}