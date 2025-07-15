using System.Collections;

class CSStudy
{
    public void DataType()
    {

    }

    public void HashTableExample()
    {
        Hashtable ht = new Hashtable();
        ht.Add("irina", "Irina SP");
        ht.Add("tom", "Tom Cr");

        if (ht.Contains("tom"))
        {
            Console.WriteLine(ht["tom"]);
        }
    }
}