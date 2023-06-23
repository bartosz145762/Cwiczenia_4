using System;

class Program
{
    static void Main()
    {
        Console.Title = "Zadanie 2";

        Console.WriteLine("Algorytm do znajdowania największej oraz najmniejszej wartości w tablicy");
        Console.WriteLine();

        int[] tablica = new int[10];
        Random losowaLiczba = new Random();

        for (int i = 0; i < tablica.Length; i++)
        {
            tablica[i] = losowaLiczba.Next(1, 100);
        }

        int najmniejszy = tablica[0];
        int najwiekszy = tablica[0];

        for (int i = 1; i < tablica.Length; i++)
        {
            if (tablica[i] < najmniejszy)
            {
                najmniejszy = tablica[i];
            }

            if (tablica[i] > najwiekszy)
            {
                najwiekszy = tablica[i];
            }
        }

        Console.WriteLine("Najmniejszy element w tablicy: " + najmniejszy);
        Console.WriteLine("Największy element w tablicy: " + najwiekszy);

        Console.ReadLine();
    }
}