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
        zad8();
        Console.ReadKey();

    }



    static private void zad8()
    //  Napisz algorytm do zgadywania jaką liczbę z przedziału 1-20 ma na myśli użytkownik.
    // Algorytm powinien proponować liczby, a użytkownik powinien odpowiadać:
    // i.liczbą ujemną, jeśli propozycja jest mniejsza od szukanej liczby,
    // ii.liczbą dodatnią, jeśli propozycja jest większa od szukanej liczby,
    // iii.zerem jeśli algorytm odgadł liczbę.
    // Spróbuj zminimalizować liczbę pytań koniecznych do znalezienia szukanej liczby.
    {
        Console.WriteLine("zagramy w gre, zgadne twoja liczbe z przedziału 1-20, jednak musisz mi pomóc, a o to zasady:  ");
        Console.WriteLine("podaj liczbe ujemna jesli liczba jest mniejsza : ");
        Console.WriteLine("podaj liczbe dodatania jesli liczba jest wieksza : ");
        Console.WriteLine("nacisnij 0 jesli wygrałem! ");

        Random r = new Random();


        int[] wyniki = new int[] { };

        int liczbaStrzalow = 5;



        int strzalUzytkownika;
        int min = 1;
        int max = 21;
        // method random don't return max value so i increased by one here.
        for (int i = 1; i < liczbaStrzalow + 1; i++)
        {


            int rLiczba = r.Next(min, max);
            int check = Array.IndexOf(wyniki, rLiczba);



            while (check > 0)
            {
                rLiczba = r.Next(min, max);

            }





            Console.WriteLine("zgaduje" + i + "raz!" + "czy liczba to ...." + rLiczba + "???");
            wyniki.Append(rLiczba);


            strzalUzytkownika = Convert.ToInt32(Console.ReadLine());



            if (strzalUzytkownika == 0)
            {
                Console.WriteLine("jestem najlepszy wygrałem za " + i + " !");
                break;

            }
            else if (strzalUzytkownika > 0)
            {
                min = rLiczba;

                Console.WriteLine("liczba jest wieksza!");
            }
            else
            {
                max = rLiczba;
                Console.WriteLine("liczba jest mniejsza!");
            }

            if (liczbaStrzalow == i)
            {
                Console.WriteLine("spróbuj ponownie ! :) ");
            };


        }
    }

}



