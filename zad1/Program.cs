using System;
using System.Diagnostics.Tracing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

public class Lab003
{
    public static void Main()
    {
        zad1();
    }

    static private void zad1()

    {
        //int baseNum, int powNum,
        Console.WriteLine("wprowadź dwie liczby 1 podstawe 2 mnożnik ");

        int baseNum = Convert.ToInt32(Console.ReadLine());
        int powNum = Convert.ToInt32(Console.ReadLine());
        int result = 1;
        for (int i = 0; i < powNum; i++)
        {
            result = result * baseNum;
        }
        Console.WriteLine("potega to  " + result);
        Console.ReadKey();
    }

}



