using System;

/*
Kirjoittanut: Aarni Junkkala
Tehtävänanto:
Tehtävänäsi on esitellä allaolevat muuttujat ja alustaa ne sopivilla arvoilla.

var1 = 8-bittinen etumerkillinen kokonaisluku
var2 = 64-bittinen etumerkillinen kokonaisluku
var3 = 16-bittinen etumerkitön kokonaisluku
var4 = 64-bittinen double-precision liukuluku
*/

class Conversions
{
    static void Main(string[] args)
    {
        sbyte var1 = 0;
        Int64 var2 = 0;
        UInt16 var3 = 0;
        double var4 = 0;

        if(var1.GetType() == typeof(SByte))
        {
            Console.WriteLine("var 1 tyyppi ok.");
        }
        if (var2.GetType() == typeof(Int64))
        {
            Console.WriteLine("var 2 tyyppi ok.");
        }
        if (var3.GetType() == typeof(UInt16))
        {
            Console.WriteLine("var 3 tyyppi ok.");
        }
        if (var4.GetType() == typeof(double))
        {
            Console.WriteLine("var 4 tyyppi ok.");
        }
    } 
}