using Euler.Algorithms.Abstract;
using Euler.Algorithms.Interface;

namespace Euler.Algorithms.Concrete;

public class LargestProductInASeries : AbstractAlgorithm, IAlgorithmic
{
    public void Run()
    {
        Console.WriteLine();
        Console.Write("From how many digits do you want the number to be formed: ");
        var numberOfDigits = GetUserNumber();
        List<char> charArray = new List<char>();

        string str1 = "73167176531330624919225119674426574742355349194934";
        str1 += "96983520312774506326239578318016984801869478851843";
        str1 += "85861560789112949495459501737958331952853208805511";
        str1 += "12540698747158523863050715693290963295227443043557";
        str1 += "66896648950445244523161731856403098711121722383113";
        str1 += "62229893423380308135336276614282806444486645238749";
        str1 += "30358907296290491560440772390713810515859307960866";
        str1 += "70172427121883998797908792274921901699720888093776";
        str1 += "65727333001053367881220235421809751254540594752243";
        str1 += "52584907711670556013604839586446706324415722155397";
        str1 += "53697817977846174064955149290862569321978468622482";
        str1 += "83972241375657056057490261407972968652414535100474";
        str1 += "82166370484403199890008895243450658541227588666881";
        str1 += "16427171479924442928230863465674813919123162824586";
        str1 += "17866458359124566529476545682848912883142607690042";
        str1 += "24219022671055626321111109370544217506941658960408";
        str1 += "07198403850962455444362981230987879927244284909188";
        str1 += "84580156166097919133875499200524063689912560717606";
        str1 += "05886116467109405077541002256983155200055935729725";
        str1 += "71636269561882670428252483600823257530420752963450";

        char[] ch1 = str1.ToCharArray();


        charArray.AddRange(ch1);


        long largest = 0;
        var startIndex = 0;
        for (startIndex = 0; startIndex < str1.Length - numberOfDigits; startIndex++)
        {
            long product = int.Parse(charArray[startIndex].ToString());
            for (int i = 1; i < numberOfDigits; i++)
            {
                product *= int.Parse(charArray[startIndex + i].ToString());
            }

            if (product > largest)
            {
                largest = product;
            }
        }

        Console.WriteLine("Largest product is: " + largest);
    }
}