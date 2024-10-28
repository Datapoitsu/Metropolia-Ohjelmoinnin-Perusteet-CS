using System;

/*
Kirjoittanut: Aarni Junkkala
Tehtävänanto:
Tehtävänäsi on esitellä alla olevat muuttujat ja antaa niille sopivat arvot:

var1 tyyppiä short
var2 tyyppiä byte
var3 tyyppiä float
var4 tyyppiä char
var5 tyyppiä boolean
var6 tyyppiä ulong
var7 tyyppiä decimal.
*/

class Tietotyypit
{
    static void Main(string[] args)
    {
        short var1 = 0;
        byte var2 = 0;
        Single var3 = 0;
        char var4 = ' ';
        bool var5 = false;
        UInt64 var6 = 0;
        decimal var7 = 0;

        Console.WriteLine("Var1 on tyyppiä " + var1.GetType());
        Console.WriteLine("Var2 on tyyppiä " + var2.GetType());
        Console.WriteLine("Var3 on tyyppiä " + var3.GetType());
        Console.WriteLine("Var4 on tyyppiä " + var4.GetType());
        Console.WriteLine("Var5 on tyyppiä " + var5.GetType());
        Console.WriteLine("Var6 on tyyppiä " + var6.GetType());
        Console.WriteLine("Var7 on tyyppiä " + var7.GetType());
    } 
}