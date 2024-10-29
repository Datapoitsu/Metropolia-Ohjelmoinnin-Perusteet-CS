using System;
using System.IO;
/*
Kirjoittanut: Aarni Junkkala
Tehtävänanto:
Kirjoita C#-ohjelma joka ottaa komentoriviargumenttina tiedoston nimen, ja tulostaa kyseisen tiedoston sisällön ruudulle.

Huom: ohjelman tulee tarkistaa, onko komentoriviargumenttia annettu, ja kielteisessä tapauksessa tulostaa "Ei tiedostonimeä!". Ohjelman tulee myös tarkistaa, että annetulla tiedostonimellä myös löytyy tiedosto ennen kuin sitä koitetaan lukea.
 */

class Program
{
    static void Main(string[] args)
    {
        string filename, content;
        if (args.Length <= 0)
        {
            Console.WriteLine("Ei tiedostonimeä!");
            return;
        }
        if (!File.Exists(args[0]))
        {
            Console.WriteLine("Tiedostoa ei löytynyt!");
            return;
        }
        filename = args[0];
        content = File.ReadAllText(filename);
        Console.WriteLine(content);

    }
}