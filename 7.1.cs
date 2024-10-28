using System;
using System.Collections.Generic;
/*
Kirjoittanut: Aarni Junkkala
Tehtävänanto:
Kirjoita ohjelma, joka pyytää käyttäjää syöttämään kokonaislukuja, kunnes ohjelma saa syötteenä negatiivisen luvun. Syötetyt luvut tulee lisätä int-tyyppiseen listaan (List) nimeltä numerot.

Huom! Sinun tarvitsee kirjoittaa vain List-esittely, käyttäjän syötteiden käsittely (käytä annettua muuttujaa int syote) sekä elementtien lisäys listalle.

 */

class Program
{
    static void Main(string[] args)
    {
        int syote;
        
        List<int> numerot = new List<int>();
        while(true)
        {
            Console.Write("Syötä numero:");
            syote = int.Parse(Console.ReadLine());
            if(syote < 0)
            {
                break;
            }
            numerot.Add(syote);
        }

        Console.WriteLine("Syöttämäsi numerot: ");
        foreach (int numero in numerot)
        {
            Console.WriteLine(numero + " ");
        }
    }
}