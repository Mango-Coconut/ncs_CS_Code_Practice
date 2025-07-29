namespace testNS
{
    class Util
    {
        public static IEnumerable<int> GetNumber()
        {
            int n = 1;
            while (n < 10)
            {
                yield return n++ * 10;
            }
         }
    }
}