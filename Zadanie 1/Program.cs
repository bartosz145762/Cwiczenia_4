using System;

class Program
{
    static void Main()
    {
        Console.Title = "Zadanie 1";

        Console.WriteLine("Algorytm do wypisywanie zawartości tablicy od tyłu");
        Console.WriteLine();

        int[] tablica = new int[10];
        Random random = new Random();

        for (int i = 0; i < tablica.Length; i++)
        {
            tablica[i] = random.Next(1, 100);
        }

        Console.WriteLine("Zawartość tablicy od tyłu:");
        for (int i = tablica.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(tablica[i]);
        }

        Console.ReadLine();
    }
}