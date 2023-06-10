using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

public class Lab01
{
    public static void Main()
    {
        double zadanie;
        Console.WriteLine("ktory program chcesz rozwiazac? jesli chcesz wyjsc wybierz 0 ");
        zadanie = inputValue();
        if (zadanie == 1)
        {
            zad1();
            Main();
        }
        else if (zadanie == 2)
        {
            zad2();
            Main();
        }
        else if (zadanie == 3)
        {
            zad3();
            Main();
        }
        else if (zadanie == 4)
        {
            zad4();
            Main();
        }
        else if (zadanie == 6)
        {
            zad6();
            Main();
        }
        else if (zadanie == 7)
        {
            zad7();
            Main();
        }
        else if (zadanie == 8)
        {
            zad8();
            Main();
        }
        else if (zadanie == 0)
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("narazie mamy tylko zadania od 1 do 8 jesli chcesz wyjsc wścisnij 0, powodzenia");
            Main();
        }
    }






    static private int zad1()

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
        return result;

    }


    static private int zad2()

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

        return a;
    }


    static private int zad3()

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


        return m;
    }


    static private int zad4()
    // Wczytaj kwotę początkową którą wpłacisz na konto oszczędnościowe, oprocentowanie
    // konta w skali roku, oraz liczbę miesięcy oszczędzania.Zakładając, że nie dodajesz
    // nowych środków, oraz że odsetki są naliczane co miesiąc(z oprocentowaniem równym
    // 1 /12 oprocentowania w skali roku), oblicz jaką kwotę zarobisz(uwzględnij tzw.
    // „podatek Belki”). 
    {
        Console.WriteLine("obliczymy twoje zyski, na poczatku podaj kwote która wpłacasz ");
        double kapital = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("teraz podaj  twoje oprocentowanie w skali roku");
        double oprocentowanie = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("teraz liczbe miesiecy");
        double liczbaMsc = Convert.ToInt32(Console.ReadLine());

        double oprocentowanieMsc = oprocentowanie / 12;

        double oprocentowanieWSkaliLolaty = oprocentowanieMsc * liczbaMsc;

        double zyskiPlusPodatki = kapital * oprocentowanieWSkaliLolaty;

        double zyskiMinusPodatki = (zyskiPlusPodatki / 100) * 81;


        Console.WriteLine("zarobisz na tym " + zyskiMinusPodatki);



        return 0;
    }


    static private int zad6()
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

        return 0;
    }

    static private int zad7()
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



     

        return 0;

    }
    static private int zad8()
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
        for (int i = 1; i < liczbaStrzalow+1 ; i++)
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



            if (strzalUzytkownika == 0) {
                Console.WriteLine("jestem najlepszy wygrałem za " + i + " !");
                break;
                
            }
            else if(strzalUzytkownika > 0)
            {
                min = rLiczba;

                Console.WriteLine("liczba jest wieksza!");
            }
            else
            {
                max = rLiczba;
                Console.WriteLine("liczba jest mniejsza!");
            }

            if(liczbaStrzalow  == i) {
                Console.WriteLine("spróbuj ponownie ! :) ");
                    };


        }









        return 0;

    }

   



    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}

