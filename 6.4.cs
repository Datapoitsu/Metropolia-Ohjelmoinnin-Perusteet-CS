using System;

/*
Kirjoittanut: Aarni Junkkala
Tehtävänanto:
Käytä foreach-lausetta tulostaaksesi taulukon "merkit" sisältö.
*/

class Program
{
    static void Main(string[] args)
    {
        int[] data = new int[args.Length];
        for(int i = 0; i < args.Length; i++)
        {
            data[i] = int.Parse(args[i]);
        }
        data = BubbleSort(data);
        for(int i = 0; i < data.Length; i++)
        {
            Console.Write(data[i] + " ");
        }
    }

    static int[] BubbleSort(int[] data)
    {
        for(int i = 1; i < data.Length - 1; i++)
        {
            for(int k = 0; k < data.Length - 1; k++)
            {
                if (data[k] > data[k + 1])
                {
                    int holder = data[k];
                    data[k] = data[k + 1];
                    data[k + 1] = holder;
                }
            }
        }

        return data;
    }
}