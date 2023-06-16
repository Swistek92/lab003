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
        zad5();
        Console.ReadKey();

    }



    static private void zad5()
    {
        Console.WriteLine("Podaj n i x:");
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());

        double edox = 1;
        for (int i = 0; i <= n; i++)
        {
            double temp = edox;
            edox = edox + (potęga(x, i) / silnia(i));
        }

        Console.WriteLine("e^x =:" + edox);









        int potęga(int a, int b)
        {
            int temp = a;
            if (b == 0)
            {
                return 1;
            }
            for (int i = 1; i < b; i++)
            {
                a = a * temp;
            }

            return a;
        }
        int silnia(int a)
        {
            int wynik = 1;
            for (int i = 1; i <= a; i++)
            {
                wynik = wynik * i;
            }
            return wynik;
        }
    }


}



