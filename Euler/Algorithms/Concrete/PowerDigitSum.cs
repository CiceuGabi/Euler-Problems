using System.Numerics;
using Euler.Algorithms.Abstract;
using Euler.Algorithms.Interface;

namespace Euler.Algorithms.Concrete;

public class PowerDigitSum : AbstractAlgorithm, IAlgorithmic
{
    public void Run()
    {
        Console.WriteLine();
        Console.Write("Enter your exponent number: ");
        var number = GetUserNumber();
        int sum = 0;
        BigInteger big = (BigInteger)Math.Pow(2, number);
        foreach (var item in big.ToString().ToCharArray())
        {
            sum += Int32.Parse(item.ToString());
        }

        Console.WriteLine("The sum of the digits is: " + sum);
    }
}