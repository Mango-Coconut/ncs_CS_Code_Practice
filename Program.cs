using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;

internal class Program
{

    private static void Main(string[] args)
    {
        Solution sol = new Solution();
        CSStudy cs = new CSStudy();

        int n = 15;
        while (n > 0)
        {
            n = n >> 1;
            Console.WriteLine(n);
        }
    }
}