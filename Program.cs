using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;

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

        SortedDictionary<int, string> tmap = new SortedDictionary<int, string>();
        tmap.Add(1, "asd");
        tmap.Add(2, "ass");
        tmap.Add(3, "asf");
        string s = tmap[1];
        foreach (var kv in tmap)
        {
            int a = kv.Key;
            string b = kv.Value;
        }
    }

}