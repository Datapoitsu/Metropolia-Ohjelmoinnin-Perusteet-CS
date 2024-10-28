using System;

/*
Kirjoittanut: Aarni Junkkala
Tehtävänanto:
Tehtävänäsi on ohjelmoida C#-peli "Torakka, Jalka, Ydinase". Pelillä on samat säännöt kuin Kivi, Paperi, Sakset -pelillä – torakka häviää jalalle, jalka häviää ydinaseelle ja ydinase häviää torakalle.
*/

class Program
{
    static void Main(string[] args)
    {
        int valinta = 0;
        Random random = new Random();
        while(valinta != 4)
        {
            Console.WriteLine("Torakka - Jalka - Ydinase.Valitse 1 - 4");
            Console.WriteLine("1) Torakka 2) Jalka 3) Ydinase 4) Poistu");
            ConsoleKeyInfo CK = Console.ReadKey();
            if(CK.Key == ConsoleKey.D4)
            {
                break;
            }
            if(CK.Key == ConsoleKey.D1)
            {
                valinta = 1;
            }
            if (CK.Key == ConsoleKey.D2)
            {
                valinta = 2;
            }
            if (CK.Key == ConsoleKey.D3)
            {
                valinta = 3;
            }
            Console.WriteLine(" " + numToName(valinta) + "!");
            int vihu = random.Next(1,4);
            Console.WriteLine("Tietokone valitsi: " + numToName(vihu) + ". " + WinStatus(valinta, vihu) + "\n");
        }
        

    }

    static string numToName(int num)
    {
        string[] names = { "Torakka", "Jalka", "Ydinase" };
        return names[num - 1];
    }

    static string WinStatus(int p1,int p2)
    {
        if(p1 == p2) { return "Tasapeli!"; }
        if(
            p1 == 2 && p2 == 1 ||
            p1 == 3 && p2 == 2 ||
            p1 == 1 && p2 == 3
        ) { return "Pelaaja voitti"; }
        if (
            p1 == 1 && p2 == 2 ||
            p1 == 2 && p2 == 3 ||
            p1 == 3 && p2 == 1
        ) { return "Tietokone voitti"; }
        return "";
    }
}