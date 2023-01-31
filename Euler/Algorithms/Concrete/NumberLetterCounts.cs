using Euler.Algorithms.Abstract;
using Euler.Algorithms.Interface;

namespace Euler.Algorithms.Concrete;

public class NumberLetterCounts : AbstractAlgorithm, IAlgorithmic
{
    public void Run()
    {
        Console.WriteLine();
        Console.Write("Enter a number between 1 and 1000: ");
        var number = GetUserNumber();
        while (number is > 1000 or < 1)
        {
            Console.Write("The number must be between 1 and 1000. Try again: ");
            number = GetUserNumber();
        }

        Console.WriteLine();
        var count = 0;
        for (int i = 1; i <= number; i++)
        {
            count += LetterCounts(i)!.Replace(" ", "").Length;
        }

        Console.WriteLine("There are {0} letters from 1 to {1}", count, number);
    }

    private static string? LetterCounts(int inputNum)
    {
        var inputString = inputNum.ToString();
        if (inputNum is > 0 and < 10)
        {
            return Ones(inputString);
        }
        else if (inputNum is >= 10 and < 100)
        {
            return Tens(inputString);
        }
        else
        {
            return Hundreds(inputString);
        }
    }

    private static string Ones(string number)
    {
        var num = Convert.ToInt32(number);
        var name = num switch
        {
            1 => "One",
            2 => "Two",
            3 => "Three",
            4 => "Four",
            5 => "Five",
            6 => "Six",
            7 => "Seven",
            8 => "Eight",
            9 => "Nine",
            _ => ""
        };

        return name;
    }

    private static string? Tens(string number)
    {
        var num = Convert.ToInt32(number);
        string? name = null;
        switch (num)
        {
            case 10:
                name = "Ten";
                break;
            case 11:
                name = "Eleven";
                break;
            case 12:
                name = "Twelve";
                break;
            case 13:
                name = "Thirteen";
                break;
            case 14:
                name = "Fourteen";
                break;
            case 15:
                name = "Fifteen";
                break;
            case 16:
                name = "Sixteen";
                break;
            case 17:
                name = "Seventeen";
                break;
            case 18:
                name = "Eighteen";
                break;
            case 19:
                name = "Nineteen";
                break;
            case 20:
                name = "Twenty";
                break;
            case 30:
                name = "Thirty";
                break;
            case 40:
                name = "Forty";
                break;
            case 50:
                name = "Fifty";
                break;
            case 60:
                name = "Sixty";
                break;
            case 70:
                name = "Seventy";
                break;
            case 80:
                name = "Eighty";
                break;
            case 90:
                name = "Ninety";
                break;
            default:
                if (num > 0)
                {
                    name = Tens(number.Substring(0, 1) + "0") + " " + Ones(number.Substring(1));
                }

                break;
        }

        return name;
    }

    private static string? Hundreds(string number)
    {
        var num = Convert.ToInt32(number);
        string? name = null;
        switch (num)
        {
            case 100:
                name = "One Hundred";
                break;
            case 200:
                name = "Two Hundred";
                break;
            case 300:
                name = "Three Hundred";
                break;
            case 400:
                name = "Four Hundred";
                break;
            case 500:
                name = "Five Hundred";
                break;
            case 600:
                name = "Six Hundred";
                break;
            case 700:
                name = "Seven Hundred";
                break;
            case 800:
                name = "Eight Hundred";
                break;
            case 900:
                name = "Nine Hundred";
                break;
            case 1000:
                name = "One Thousand";
                break;
            default:
                if (num is >= 110 and <= 119)
                {
                    name = Hundreds(number.Substring(0, 1) + "00") + " and " + Tens(number.Substring(1, 2));
                }
                else if (num is >= 101 and <= 109)
                {
                    name = Hundreds(number.Substring(0, 1) + "00") + " and " + Ones(number.Substring(2));
                }

                else if (num is >= 210 and <= 219)
                {
                    name = Hundreds(number.Substring(0, 1) + "00") + " and " + Tens(number.Substring(1, 2));
                }
                else if (num is >= 201 and <= 209)
                {
                    name = Hundreds(number.Substring(0, 1) + "00") + " and " + Ones(number.Substring(2));
                }

                else if (num is >= 310 and <= 319)
                {
                    name = Hundreds(number.Substring(0, 1) + "00") + " and " + Tens(number.Substring(1, 2));
                }
                else if (num is >= 301 and <= 309)
                {
                    name = Hundreds(number.Substring(0, 1) + "00") + " and " + Ones(number.Substring(2));
                }

                else if (num is >= 410 and <= 419)
                {
                    name = Hundreds(number.Substring(0, 1) + "00") + " and " + Tens(number.Substring(1, 2));
                }
                else if (num is >= 401 and <= 409)
                {
                    name = Hundreds(number.Substring(0, 1) + "00") + " and " + Ones(number.Substring(2));
                }

                else if (num is >= 510 and <= 519)
                {
                    name = Hundreds(number.Substring(0, 1) + "00") + " and " + Tens(number.Substring(1, 2));
                }
                else if (num is >= 501 and <= 509)
                {
                    name = Hundreds(number.Substring(0, 1) + "00") + " and " + Ones(number.Substring(2));
                }

                else if (num is >= 610 and <= 619)
                {
                    name = Hundreds(number.Substring(0, 1) + "00") + " and " + Tens(number.Substring(1, 2));
                }
                else if (num is >= 601 and <= 609)
                {
                    name = Hundreds(number.Substring(0, 1) + "00") + " and " + Ones(number.Substring(2));
                }

                else if (num is >= 710 and <= 719)
                {
                    name = Hundreds(number.Substring(0, 1) + "00") + " and " + Tens(number.Substring(1, 2));
                }
                else if (num is >= 701 and <= 709)
                {
                    name = Hundreds(number.Substring(0, 1) + "00") + " and " + Ones(number.Substring(2));
                }

                else if (num is >= 810 and <= 819)
                {
                    name = Hundreds(number.Substring(0, 1) + "00") + " and " + Tens(number.Substring(1, 2));
                }
                else if (num is >= 801 and <= 809)
                {
                    name = Hundreds(number.Substring(0, 1) + "00") + " and " + Ones(number.Substring(2));
                }

                else if (num is >= 910 and <= 919)
                {
                    name = Hundreds(number.Substring(0, 1) + "00") + " and " + Tens(number.Substring(1, 2));
                }
                else if (num is >= 901 and <= 909)
                {
                    name = Hundreds(number.Substring(0, 1) + "00") + " and " + Ones(number.Substring(2));
                }

                else if (num > 0)
                {
                    name = Hundreds(number.Substring(0, 1) + "00") + " and " + Tens(number.Substring(1, 2) + "0") + Ones(number.Substring(2));
                }


                break;
        }

        return name;
    }
}