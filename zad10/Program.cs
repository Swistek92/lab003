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
        zad10();
        Console.ReadKey();

    }



    static private void zad10()
    {

        Console.WriteLine("podaj cyfre a ja ją obrócę   ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] result = n.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();

        while (result.Length + 1 < 3)
        {

            Console.WriteLine("podaj minimum 3 cyfrowa liczbe! ");
            n = Convert.ToInt32(Console.ReadLine());
            result = n.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
        }



        int a;
        int b;
        void spellNumber(int n)
        {
            if (n > 0)
            {
                a = n % 10;
                Console.WriteLine(a);
                n = n - a;
                spellNumber(n);
            }

        }

        spellNumber(n);
    }

}



