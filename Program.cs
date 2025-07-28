using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;

internal class Program
{
    
    private static void Main(string[] args)
    {
        Solution sol = new Solution();
        CSStudy cs = new CSStudy();


        cs.ExceptionSample();
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