using System;
using System.IO;
/*
Kirjoittanut: Aarni Junkkala
Tehtävänanto:
Kirjoita ohjelma joka lukee nykyisen kansion sisältämät tiedostot ja tulostaa ne, yksi tiedostonimi per rivi.
 */

class Program
{
    static void Main()
    {
        string path = ".";
        string[] dirList = Directory.GetFiles(path, "*");

        if(dirList.Length > 0)
        {
            foreach(string fileName in dirList)
            {
                Console.WriteLine(fileName);
            }
        }
    }
}