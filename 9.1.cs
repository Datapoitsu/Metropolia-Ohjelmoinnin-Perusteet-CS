using System;
using System.Collections.Generic;
/*
Kirjoittanut: Aarni Junkkala
Tehtävänanto:
Kurssin viimeisessä luvussa yhdistetään kaikki tähän asti opittu luomalla projekti nimeltä Leffojen Katseluloki. Kuten nimi jo kertoo, ohjelma auttaa käyttäjää pitämään yllä listaa katsomistaan elokuvista. Ominaisuuksiin kuuluu elokuvien lisääminen ja poistaminen, tietojen tallennus ja luku tallennusmedialta, sekä yksinkertaisen katseluraportin näyttäminen.
Tässä harjoituksessa tehtävänäsi on määritellä Leffa-luokka, sen kentät ja muodostin. Luokan tulee olla serialisoitava.
Luokan ominaisuudet ovat Nimi, Kesto ja Vuosi, ja muodostimen parametreilla on sama järjestys.
*/

class Program
{
    static void Main()
    {
        List<Leffa> leffat = new List<Leffa>() { };
        leffat.Add(new Leffa("Robocop", 102, 1987));
        leffat.Add(new Leffa("Robocop 2", 117, 1990));
        leffat.Add(new Leffa("Robocop 3", 104, 1993));

        foreach (var leffa in leffat)
        {
            Console.Write("Nimi: " + leffa.Nimi + ", kesto: " + leffa.Kesto + "min, vuosi: " + leffa.Vuosi + "\n\r");
        }
    }
}

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