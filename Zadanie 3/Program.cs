using System;

class Program
{
    static void Main()
    {
        Console.Title = "Zadanie 3";

        Console.WriteLine("Algorytm do sortowania bąbelkowego");
        Console.WriteLine();

        int[] tablica = new int[10];
        Random losowaLiczba = new Random();

        for (int i = 0; i < tablica.Length; i++)
        {
            tablica[i] = losowaLiczba.Next(1, 100);
        }

        Console.WriteLine("Nieposortowana tablica:");
        WyswietlTablice(tablica);

        SortowanieBabelkowe(tablica);

        Console.WriteLine();
        Console.WriteLine("Posortowana tablica:");
        WyswietlTablice(tablica);

        Console.ReadLine();
    }

    static void WyswietlTablice(int[] tablica)
    {
        foreach (int element in tablica)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    static void SortowanieBabelkowe(int[] tablica)
    {
        int n = tablica.Length;
        bool zamiana;

        do
        {
            zamiana = false;

            for (int i = 0; i < n - 1; i++)
            {
                if (tablica[i] > tablica[i + 1])
                {
                    int temp = tablica[i];
                    tablica[i] = tablica[i + 1];
                    tablica[i + 1] = temp;

                    zamiana = true;
                }
            }

            n--;
        }
        while (zamiana);
    }
}