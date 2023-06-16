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
        zad9();
        Console.ReadKey();
    }

 
    static private void zad9()
    {
        Console.WriteLine("podaj cyfre a ja ją obrócę   ");
        int n = Convert.ToInt32(Console.ReadLine());
        // int[] result = n.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
        // string reversedWord = string.Join("", result.Reverse());
        int sum = 0;

        string a = "";



        int reverse(int num)
        {

            int r = 0;

            if (num > 0)
            {
                r = num % 10;
                sum = (sum * 10) + r;
                reverse(num / 10);
            }
            else
            {
                return 0;
            }
            return sum;
        }
        int revesed = reverse(n);
        Console.WriteLine(revesed);


    }
}



