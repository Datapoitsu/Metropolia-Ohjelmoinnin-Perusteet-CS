using System;

/*
Kirjoittanut: Aarni Junkkala
Tehtävänanto:
Kirjoita C#-ohjelma joka kysyy käyttäjän iän, sekä tulostaa onko hän oikeutettu äänestämään. Äänestämisen ikäraja on 18.*/

class Program
{
    static void Main()
    {
        int ika = 0;
        Console.WriteLine("Syötä ikäsi, ole hyvä: ");
        ika = int.Parse(Console.ReadLine());
        if(ika >= 18)
        {
            Console.WriteLine("Voit äänestää!");
        }
    }
}