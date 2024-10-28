using System;
using System.Collections.Generic;
/*
Kirjoittanut: Aarni Junkkala
Tehtävänanto:
Sinulle on annettu merkkijono-tyyppinen List, joka sisältää seuraavat nimet:
Torvalds, Musk, Gates, Buffet, Dorsey.

Muokkaa listaa niin, että sen sisältämät arvot ovat:
Jobs, Musk, McAfee, Buffet, Wozniak.

Vinkki: voit käyttää mitä vain sopivia List-luokan metodeja tehtävän suorittamiseksi.

 */

class Program
{
    static void Main()
    {
        List<string> nimet = new List<string> { "Torvalds", "Musk", "Gates", "Buffet", "Dorsey" };

        nimet[0] = "Jobs";
        nimet[2] = "McAfee";
        nimet[4] = "Wozniak";

        foreach(string nimi in nimet)
        {
            Console.WriteLine(nimi);
        }
    }
}