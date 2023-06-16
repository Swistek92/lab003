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

        zad6();
        Console.ReadKey();

    }



    static private void zad6()
    // Napisz algorytm, który sprawdzi, czy wprowadzona liczba x jest silnią liczby n i jeśli
    // tak, to niech wypisze n.
    {
        Console.WriteLine("sprawdzimy czy x jest silnia liczby n, podaj x i n ");
        int x = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());

        int silniaN = 1;


        for (int i = 1; i < n + 1 || n < x; i++)
        {
            silniaN = silniaN * i;
            if (silniaN == x)
            {
                Console.WriteLine("x jest silnia n ! " + n);
                break;
            }
        }


    }

}



