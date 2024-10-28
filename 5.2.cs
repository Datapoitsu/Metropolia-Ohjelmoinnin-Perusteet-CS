using System;

/*
Kirjoittanut: Aarni Junkkala
Tehtävänanto:
Kirjoita ohjelma, joka pyytää käyttäjää syöttämään kaksi kokonaislukua ja kertoo kumpi numeroista oli suurempi, tai jos ne olivat yhtäsuuret.
*/

class Program
{
    static void Main()
    {
        int eka = 0;
        Console.WriteLine("Syötä ensimmäinen numero: ");
        eka = int.Parse(Console.ReadLine());
        int toka = 0;
        Console.WriteLine("Syötä toinen numero: ");
        toka = int.Parse(Console.ReadLine());
        if(eka == toka)
        {
            Console.WriteLine("Numerot ovat yhtä suuret.");
        }
        if(eka > toka)
        {
            Console.WriteLine("Numero 1 on suurempi kuin numero 2.");
        }
        if(toka > eka)
        {
            Console.WriteLine("Numero 2 on suurempi kuin numero 1.");
        }
    }
}