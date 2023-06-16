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
        string random = "asdb";
        string randomToCapital = ToCapital(random);
        Console.WriteLine(randomToCapital);
        Console.ReadKey();

    }



    static private string ToCapital(string word)
    {


        int a;




        string[] ch = new string[word.Length];

        for (int i = 0; i < word.Length; i++)
        {
            ch[i] = word[i].ToString();
        }

        ch[0] = ch[0].ToUpper();

        for (int i = 1; i < ch.Length; i++)
        {
            ch[i] = ch[i].ToLower();

        }

        return string.Join("", ch);




    }

}



