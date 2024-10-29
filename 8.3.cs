using System;
using System.IO;
/*
Kirjoittanut: Aarni Junkkala
Tehtävänanto:
Luo ohjelma, joka avaa olemassaolevan tiedoston, pyytää käyttäjältä sisältöä, ja lisää (append) annetun sisällön tiedostoon.
*/

class Program
{
    static void Main()
    {
        Console.Write("Tiedosto johon lisätään: ");
        string filename, content;
        filename = Console.ReadLine();
        Console.WriteLine("Syötä tiedostoon " + filename + " lisättävä sisältö:");
        content = Console.ReadLine();
        content.Remove(content.Length - 1, 1);
        using(StreamWriter sw = new StreamWriter(filename,true))
        {
            for(int i = 0; i < content.Length; i++)
            {
                sw.Write(content[i]);
            }
            sw.Write('\n');
            sw.Close();
        }
        
    }
}