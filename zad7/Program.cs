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
        zad7();
        Console.ReadKey();
    }

  

    static private void zad7()
    //  Napisz algorytm, który wypisze wszystkie pary liczb naturalnych, których suma jest
    // równa wprowadzonej liczbie n.
    {
        Console.WriteLine("wypisze dla ciebie wszystkie pary liczb naturalnych ktorych suma jest równa  n, więc prosze podać n:  ");
        int n = Convert.ToInt32(Console.ReadLine());


        for (int i = 0; i < n; i++)
        {
            int y = n - i;
            Console.WriteLine(i.ToString() + "   " + y.ToString());
        }
    }

}



