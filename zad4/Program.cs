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
        zad4();
        Console.ReadKey();

    }

    static private void zad4()
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
    }


}



