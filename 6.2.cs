using System;

/*
Kirjoittanut: Aarni Junkkala
Tehtävänanto:
Kirjoita C#-ohjelma, joka pyytää käyttäjältä kokonaislukuja, kunnes niiden summa on vähintään 200. Sinun täytyy käyttää while-lausetta.
*/

class Program
{
    static void Main(string[] args)
    {
        int luku = 0;
        while(luku < 200)
        {
            Console.Write("Summa on nyt " + luku + ". Syöte: ");
            luku += int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Saavutettiin 200. Summa oli " + luku + ".");
    }
}