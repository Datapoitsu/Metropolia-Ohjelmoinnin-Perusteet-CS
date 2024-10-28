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
        int x, y;
        Console.WriteLine("Löydä xy-akseleilla olevan pisteen kvadrantti:");
        Console.Write("X-koordinaatti: ");
        x = int.Parse(Console.ReadLine());
        Console.Write("Y-koordinaatti: ");
        y = int.Parse(Console.ReadLine());
        if(x == 0 && y == 0)
        {
            Console.WriteLine("Koordinaattipiste (" + x + "," + y + ") on origossa.");
        }
        else
        {
            double kvadrantti = Math.Atan2(y-0, x-0);
            if(kvadrantti < 0)
            {
                kvadrantti += Math.PI * 2;
            }
            kvadrantti = kvadrantti * (180 / Math.PI);
            kvadrantti = Math.Floor(kvadrantti / 90) + 1;
            Console.WriteLine("Koordinaattipiste (" + x + "," + y + ") on kvadrantissa " + kvadrantti + ".");
        }
    }
}