using System;

/*
Kirjoittanut: Aarni Junkkala
Tehtävänanto:
Esittele ja alusta muuttujat a, b ja c niin, että ohjelma tulostaa "Onnistui!".
*/

class Program
{
    static void Main(string[] args)
    {
        int a = 2;
        int b = 3;
        int c = 1;

        if ( (a != b) && (a < b))
        {
            if(a > c)
            {
                Console.WriteLine("Onnistui!");
            }
        }
        else
        {
            Console.WriteLine("Yritä uudestaan!");
        }
    } 
}