using System;

/*
Kirjoittanut: Aarni Junkkala
Tehtävänanto:
Esittele ja alusta muuttujat x, y, z ja b niin, että ohjelma tulostaa "Onnistui!".
*/

class Program
{
    static void Main()
    {
        int x = 1;
        int y = 0;
        int z = 2;
        string s = "C";
        if(((x >= y) && (y < z)) || ((x > y) && (s == "A")))
        {
            if(s == "C")
            {
                Console.WriteLine("Onnistui!");
            }
            else
            {
                Console.WriteLine("Melkein!");
            }
        }
        else
        {
            Console.WriteLine("Ei iha, yritä vielä!");
        }
    }
}