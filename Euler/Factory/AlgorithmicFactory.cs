using Euler.Algorithms.Concrete;
using Euler.Algorithms.Interface;

namespace Euler.Factory;

public class AlgorithmicFactory
{
    public IAlgorithmic Create(int number)
    {
        IAlgorithmic algorithmic = null;

        switch (number)
        {
            case 1:
            {
                algorithmic = new MultiplesOf3Or5();
                break;
            }
            case 2:
            {
                algorithmic = new EvenFibonacciNumbers();
                break;
            }
            case 3:
            {
                algorithmic = new LargestPrimeFactor();
                break;
            }
            case 4:
            {
                algorithmic = new LargestPalindromeProduct();
                break;
            }
            case 5:
            {
                algorithmic = new SmallestMultiple();
                break;
            }
            case 6:
            {
                algorithmic = new SumSquareDifference();
                break;
            }
            case 7:
            {
                algorithmic = new StPrime();
                break;
            }
            case 8:
            {
                algorithmic = new LargestProductInASeries();
                break;
            }
            case 9:
            {
                algorithmic = new SpecialPythagoreanTriplet();
                break;
            }
            case 10:
            {
                algorithmic = new SummationOfPrimes();
                break;
            }
            case 11:
            {
                algorithmic = new PowerDigitSum();
                break;
            }
            case 12:
            {
                algorithmic = new LargeSum();
                break;
            }
            case 13:
            {
                algorithmic = new HighlyDivisibleTriangularNumber();
                break;
            }
            case 14:
            {
                algorithmic = new NumberLetterCounts();
                break;
            }
            case 15:
            {
                algorithmic = new FactorialDigitSum();
                break;
            }
            case 16:
            {
                algorithmic = new Digit1000FibonacciNumber();
                break;
            }
            default:
            {
                if (algorithmic == null)
                {
                    Console.WriteLine("Exiting the program...");
                    Environment.Exit(0);
                }
                break;
            }
        }

        return algorithmic;
    }
}