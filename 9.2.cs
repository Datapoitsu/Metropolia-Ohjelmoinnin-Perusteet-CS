using System;
using System.Collections.Generic;
/*
Kirjoittanut: Aarni Junkkala
Tehtävänanto:
Tehtävänäsi on luoda Leffojen Katselulokin ohjelmalogiikka.
Ohjelma näyttää päävalikon ja pyytää syötettä. Jos syöte kelpaa,
ohjelma tulostaa valitun vaihtoehdon nimen,
ja muussa tapauksessa "Tuntematon komento".
Vinkki: voit tehdä ohjelman logiikan omaan luokkaansa,
ja kutsut valittua metodia syötteestä riippuen.

*/

class Program
{
    static void Main()
    {
        Console.Write("\n\r\n\r");
        while (true)
        {
            Console.WriteLine("Leffojen Katseluloki");
            Console.WriteLine("====================");
            Console.WriteLine("1) Lisää Leffa");
            Console.WriteLine("2) Poista Leffa");
            Console.WriteLine("3) Näytä Raportti");
            Console.WriteLine("4) Lataa Tietokanta");
            Console.WriteLine("5) Tallenna Tietokanta");
            Console.WriteLine("6) Lopeta");
            Console.Write("Syöte: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("\n\r");
            switch (num)
            {
                case 1:
                    LisaaLeffa();
                    break;
                case 2:
                    PoistaLeffa();
                    break;
                case 3:
                    NaytaRaportti();
                    break;
                case 4:
                    LataaTietokanta();
                    break;
                case 5:
                    TallennaTietokanta();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Tuntematon komento");
                    break;
            }
            Console.Write("\n\r\n\r");
        }
    }
    static void LisaaLeffa()
    {
        Console.WriteLine("Lisää Leffa");
    }

    static void PoistaLeffa()
    {
        Console.WriteLine("Poista Leffa");
    }

    static void NaytaRaportti()
    {
        Console.WriteLine("Näytä Raportti");
    }

    static void LataaTietokanta()
    {
        Console.WriteLine("Lataa Tietokanta");
    }

    static void TallennaTietokanta()
    {
        Console.WriteLine("Tallenna Tietokanta");
    }
}