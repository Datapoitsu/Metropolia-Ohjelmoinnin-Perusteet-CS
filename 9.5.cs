using System;
using System.Collections.Generic;
using System.IO;
/*
Kirjoittanut: Aarni Junkkala
Tehtävänanto:
Parantele Leffojen Katselulokia lisäämällä ominaisuus leffatietokannan tallentamiselle.
Tietokantatiedoston nimi tulee olla tietokanta.xml.
Käytä serialisaatiota tallentaaksesi Leffa-olioiden kokoelma tietokantaan.
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
                    PoistaLeffa(leffat);
                    break;
                case 3:
                    NaytaRaportti(leffat);
                    break;
                case 4:
                    LataaTietokanta();
                    break;
                case 5:
                    TallennaTietokanta(leffat);
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

    static void PoistaLeffa(List<Leffa> leffat)
    {
        Console.WriteLine("Poista Leffa:");
        for (int i = 0; i < leffat.Count; i++)
        {
            Console.WriteLine((i + 1) + ") " + leffat[i].Nimi + " (" + leffat[i].Vuosi + "), " + leffat[i].Kesto + " minuuttia.  ");
        }
        Console.Write("Syöte: ");
        leffat.RemoveAt(int.Parse(Console.ReadLine()) - 1);
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

    static void TallennaTietokanta(List<Leffa> leffat)
    {

        Console.WriteLine("Tietokanta tallennettu.");
        string filename = "tietokanta.xml";
        string content = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\n";
        content += "<ArrayOfLeffa xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">\n";
        for (int i = 0; i < leffat.Count; i++)
        {
            content += "  <Leffa>\n";
            content += "    <Nimi>" + leffat[i].Nimi + "</Nimi>\n";
            content += "    <Kesto>" + leffat[i].Kesto + "</Kesto>\n";
            content += "    <Vuosi>" + leffat[i].Vuosi + "</Vuosi>\n";
            content += "  </Leffa>\n";
        }
        content += "</ArrayOfLeffa>";

        using (StreamWriter sw = new StreamWriter(filename))
        {
            for (int i = 0; i < content.Length; i++)
            {
                sw.Write(content[i]);
            }
            sw.Close();
        }
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