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
        zad2();
    }

 
    static private void zad2()

    {
        //int baseNum, int powNum,
        Console.WriteLine("który wyraz ciagu Fibonacciego chcesz uzyskac");
        int index = Convert.ToInt32(Console.ReadLine());

        int a = 0;
        int b = 1;
        int c = 0;
        for (int i = 0; i < index; i++)
        {
            c = b;
            b = c + a;
            a = c;
        }
        Console.WriteLine("wyraz ciagu to " + a);
        Console.ReadKey();

    }
}



