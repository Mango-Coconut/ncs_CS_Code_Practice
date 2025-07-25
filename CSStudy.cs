using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Text;

class CSStudy
{
    [Flags]
    enum Border
    {
        None = 0,
        Top = 1,
        Right = 2,
        Bottom = 4,
        Left = 8
    }
    public void EnumExample()
{

    Border b = Border.Top | Border.Bottom;
    if ((b & Border.Top) != 0)
    {
        if (b.HasFlag(Border.Bottom))
        {
            Console.WriteLine(b.ToString());
        }
    }
}

    
}