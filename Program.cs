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

        Random rand = new Random();
        int[] nums = new int[10];
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = rand.Next() % 100;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        Console.WriteLine(sum);
    }

}