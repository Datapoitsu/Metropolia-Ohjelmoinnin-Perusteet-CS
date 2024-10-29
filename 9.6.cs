using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
/*
Kirjoittanut: Aarni Junkkala
Tehtävänanto:
Viimeistele Leffojen Katseluloki lisäämällä ominaisuus ladata leffatietokanta tiedostosta.
Mikäli tietokanta.xml-tiedostoa ei ole olemassa, ohjelman tulee tulostaa "Tietokantaa ei saatavilla."
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
                    LataaTietokanta(leffat);
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

    static void LataaTietokanta(List<Leffa> leffat)
    {
        Console.WriteLine("Tietokanta ladattu.");
        string filename = "tietokanta.xml";
        if (!File.Exists(filename))
        {
            Console.WriteLine("Tiedostoa ei löytynyt!");
            return;
        }
        StreamReader sr = new StreamReader(filename);
        string line = sr.ReadLine();
        string nimi = "";
        string kesto = "";
        string vuosi = "";
        int riviNumero = 0;
        while(line != null)
        {
            riviNumero++;
            line = sr.ReadLine();
            if(riviNumero > 1)
            {
                if(line == "</ArrayOfLeffa>")
                {
                    break;
                }
                if((riviNumero - 2) % 5 == 1)
                {
                    nimi = line.Substring(line.IndexOf(">") + 1, line.IndexOf("<", line.IndexOf(">") + 1) - 1 - line.IndexOf(">"));
                }
                if ((riviNumero - 2) % 5 == 2)
                {
                    kesto = line.Substring(line.IndexOf(">") + 1, line.IndexOf("<", line.IndexOf(">") + 1) - 1 - line.IndexOf(">"));
                }
                if ((riviNumero - 2) % 5 == 3)
                {
                    vuosi = line.Substring(line.IndexOf(">") + 1, line.IndexOf("<", line.IndexOf(">") + 1) - 1 - line.IndexOf(">"));
                }
            }
            if ((riviNumero - 2) % 5 == 4)
            {
                leffat.Add(new Leffa(nimi, int.Parse(kesto), int.Parse(vuosi)));
            }
        }
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