using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;

internal class Program
{
    
    private static void Main(string[] args)
    {
        Solution sol = new Solution();
        CSStudy cs = new CSStudy();


        Console.Write($"{GetNumber()}, ");
        Console.Write($"{GetNumber()}, ");
        Console.Write($"{GetNumber()}, ");
        /*
        foreach (int i in GetNumber())
        {
            Console.Write($"{i}, ");
        }
        Console.WriteLine();
        Console.WriteLine(GetNumber().ToArray()[0]);
        */
    }

    static IEnumerable<int> GetNumber()
    {
        int n = 1;
        while (n < 10)
        {
            yield return n++ * 10;
        }
    }
}