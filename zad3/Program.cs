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
        zad3();
        Console.ReadKey();
    }




    static private void zad3()

    {


        //  Napisz algorytm do obliczania: m = (n! - k!) / k!, gdzie n i k to wczytane liczby naturalne
        //  nie mniejsze od 5(wymuś na użytkowniku podanie prawidłowych liczb).

        //int baseNum, int powNum,
        Console.WriteLine("obliczymy  m = (n! - k!) / k!    podaj n k   uwaga n i k musza byc liczbami naturalnymi nie mniejszymi niz 5!");
        int n = Convert.ToInt32(Console.ReadLine());
        int k = Convert.ToInt32(Console.ReadLine());


        while (n < 5)
        {
            Console.WriteLine("n mniejsz niz 5 ! podaj wieksza !");
            n = Convert.ToInt32(Console.ReadLine());

        }

        while (k < 5)
        {
            Console.WriteLine("n mniejsz niz 5 ! podaj wieksza !");
            n = Convert.ToInt32(Console.ReadLine());
        }

        int silniaN = 1;
        int silniaK = 1;

        for (int i = 1; i < n + 1; i++)
        {
            silniaN = silniaN * i;
        }

        for (int i = 1; i < n + 1; i++)
        {
            silniaK = silniaK * i;
        }


        int m = (silniaN - silniaK) / silniaK;

        Console.WriteLine("m = " + m);



    }
}



