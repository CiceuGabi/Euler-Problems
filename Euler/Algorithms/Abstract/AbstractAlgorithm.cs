namespace Euler.Algorithms.Abstract;

public abstract class AbstractAlgorithm
{
    public static int GetUserNumber()
    {
        string number = Console.ReadLine();
        int userNumber;

        while (!int.TryParse(number, out userNumber))
        {
            Console.Write("This is not a number. Please enter a valid number: ");
            number = Console.ReadLine();
            Console.WriteLine();
        }

        return userNumber;
    }
}