using System;

/*
Kirjoittanut: Aarni Junkkala
Tehtävänanto:
Tehtävänäsi on kirjoittaa ohjelma,
joka pyytää käyttäjää syöttämään hedelmän nimen
ja tulostaa tämän jälkeen "Lempihedelmäsi on hedelmän nimi".
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Mikä on lempihedelmäsi? ");
        string hedelma = Console.ReadLine();
        Console.WriteLine("Lempihedelmäsi on " + hedelma);
    }
}