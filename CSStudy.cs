using System.Collections;
using System.Text;

class CSStudy
{
    public void DataType()
    {

    }

    public void HashTableExample()
    {
        int[,] ints = { { 1, 2 }, { 3, 4 } };
    }
    public int solution(string myString, string pat) {
        StringBuilder str = new StringBuilder();
        
        foreach (char ch in myString)
        {
            str.Append(ch == 'A' ? 'B' : 'A');
        }
        
        return str.ToString().Contains(pat) ? 1 : 0;
    }
}