using System;

/*
Kirjoittanut: Aarni Junkkala
Tehtävänanto:
Tehtävänäsi on kirjoittaa C#-ohjelma, joka tulostaa valikon ja pyytää käyttäjältä syötettä. Sinun täytyy käyttää switch-lausetta. Valikon ja tulosteen tulee näyttää seuraavalta:

Valitse:
1) Vesi
2) Mehu
3) Limonadi
4) Lopeta
2
Valitsit Mehu.
 
*/

class Program
{
    static void Main()
    {
        int valinta = 0;
        Console.WriteLine("Valitse:");
        Console.WriteLine("1) Vesi");
        Console.WriteLine("2) Mehu");
        Console.WriteLine("3) Limonadi");
        Console.WriteLine("4) Lopeta");
        valinta = int.Parse(Console.ReadLine());
        switch (valinta)
        {
            case 1:
                Console.WriteLine("Valitsit Vesi.");
                break;
            case 2:
                Console.WriteLine("Valitsit Mehu.");
                break;
            case 3:
                Console.WriteLine("Valitsit Limonadi.");
                break;
            case 4:
                Console.WriteLine("Lopetus!");
                break;
        }
    }
}