using Euler.Algorithms.Abstract;
using Euler.Algorithms.Interface;

namespace Euler.Algorithms.Concrete;

public class ReciprocalCycles : AbstractAlgorithm, IAlgorithmic
{
    public void Run()
    {
        decimal a = 1;
        decimal b = 982;
        Console.WriteLine(a/b);
        int result = 0;
        int longest = 0;
        for (int i = 2; i < 1000; i++)
        {
            int recurringNum = ReciprocalCycles.recurringNum(i);
            if (recurringNum > longest)
            {
                longest = recurringNum;
                result = i;
            }
        }

        Console.WriteLine(result + " " + longest);
    }

    private static int recurringNum(int num)
    {
        int[] arr = new int[num + 1];
        int index = 1;
        int mod = 1;
        while (mod != 0 && arr[mod] == 0)
        {
            arr[mod] = index++;
            mod = mod * 10 % num;
        }

        if (mod == 0)
        {
            return 0;
        }

        return index - arr[mod];
    }
}