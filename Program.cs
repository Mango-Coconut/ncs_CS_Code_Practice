using System.Diagnostics.CodeAnalysis;
using System.Globalization;

internal class Program
{

    /// <summary>
    /// Main 함수
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        Solution sol = new Solution();
        CSStudy cs = new CSStudy();

        Console.WriteLine(sol.Solution0714_3_OXQUIZ(["3 - 4 = -3", "5 + 6 = 11"]));
        //Console.WriteLine();
    }

}