using System;
using System.IO;
/*
Kirjoittanut: Aarni Junkkala
Tehtävänanto:
Tehtävänäsi on kirjoittaa C#-ohjelma, joka pyytää käyttäjältä tiedostolle nimen ja sisällön. Tämän jälkeen ohjelma kirjoittaa kyseisen tiedoston käyttäjän antamalla sisällöllä.
*/

class Program
{
    static void Main()
    {
        Console.Write("Tiedostonimi: ");
        string filename, content;
        filename = Console.ReadLine();
        Console.WriteLine("Sisalto tiedostolle " + filename + ":");
        content = Console.ReadLine();
        content.Remove(content.Length - 1, 1);
        using(StreamWriter sw = new StreamWriter(filename))
        {
            for(int i = 0; i < content.Length; i++)
            {
                sw.Write(content[i]);
            }
            sw.Close();
        }
        
    }
}