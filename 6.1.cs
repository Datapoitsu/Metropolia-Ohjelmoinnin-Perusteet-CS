using System;

/*
Kirjoittanut: Aarni Junkkala
Tehtävänanto:
Kirjoita C#-ohjelma, joka ottaa vastaan yhden int-tyypin komentoriviargumentin. Ohjelman tulee tulostaa argumentin verran rivejä esimerkkitulosteen näyttämällä tavalla.
 
*/

class Program
{
    static void Main(string[] args)
    {
        int num = 0;
        string s = "";
        while (num < int.Parse(args[0]))
        {
            num++;
            s += num.ToString();
            Console.Write(s + "\n\r");
        }
    }
}