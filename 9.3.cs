using System;
using System.Collections.Generic;
/*
Kirjoittanut: Aarni Junkkala
Tehtävänanto:
Tehtävänäsi on ohjelmoida kaksi funktiota Leffojen Katselulokiin.
Valinta "Lisää Leffa" pyytää käyttäjältä elokuvan tiedot ja tallentaa ne Leffa-tyyppiseen Listiin.
"Näytä Raportti" käy läpi kaikki elokuvat listalla, tulostaen niistä raportin esimerkkitulosteen mukaisesti.
Vinkki: käytä ratkaisujasi tehtäviin 9.1 ja 9.2 pohjana ohjelman kehittämiseen.
*/

class Program
{
    static void Main()
    {
        List<Leffa> leffat = new List<Leffa>();
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
                    LisaaLeffa(leffat);
                    break;
                case 2:
                    PoistaLeffa();
                    break;
                case 3:
                    NaytaRaportti(leffat);
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
    static void LisaaLeffa(List<Leffa> leffat)
    {
        string nimi = "";
        int kesto, vuosi;
        Console.WriteLine("Lisää Leffa:");
        Console.Write("Nimi:");
        nimi = Console.ReadLine();
        Console.Write("Kesto (min):");
        kesto = int.Parse(Console.ReadLine());
        Console.Write("Vuosi:");
        vuosi = int.Parse(Console.ReadLine());
        leffat.Add(new Leffa(nimi, kesto, vuosi));
    }

    static void PoistaLeffa()
    {
        Console.WriteLine("Poista Leffa");
    }

    static void NaytaRaportti(List<Leffa> leffat)
    {
        int kesto = 0;
        for (int i = 0; i < leffat.Count; i++)
        {
            Console.WriteLine(leffat[i].Nimi + " (" + leffat[i].Vuosi + "), " + leffat[i].Kesto + " minuuttia.  ");
            kesto += leffat[i].Kesto;
        }
        Console.Write("\n\r");
        Console.WriteLine("Leffoja katsottu yhteensä " + leffat.Count + ", yhteiskesto " + kesto + " minuuttia.");
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

[Serializable]
public class Leffa
{
    public string Nimi;
    public int Kesto;
    public int Vuosi;
    public Leffa(string Nimi, int Kesto, int Vuosi)
    {
        this.Nimi = Nimi;
        this.Kesto = Kesto;
        this.Vuosi = Vuosi;
    }
}