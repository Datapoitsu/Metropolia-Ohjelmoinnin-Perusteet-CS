using System;

/*
Kirjoittanut: Aarni Junkkala
Tehtävänanto:
Kirjoita C#-ohjelma joka tulostaa ensimmäisen annetun komentoriviargumentin.
Voit olettaa, että argumentti on aina annettu,
ja koostuu kirjaimista ja numeroista.
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Komentoriviargumentti oli: " + args[0]);
    }
}