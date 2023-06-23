using System;

class Program
{
    static void Main()
    {
        Console.Title = "Zadanie 5";

        Console.WriteLine("Algorytm do sortowania przez wybieranie");
        Console.WriteLine();

        int[] tablica = new int[10];
        Random losowaLiczba = new Random();

        for (int i = 0; i < tablica.Length; i++)
        {
            tablica[i] = losowaLiczba.Next(1, 100);
        }

        Console.WriteLine("Nieposortowana tablica:");
        WyswietlTablice(tablica);

        SortowanieWybieranie(tablica);

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

    static void SortowanieWybieranie(int[] tablica)
    {
        int n = tablica.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int indeksMinimum = i;

            for (int j = i + 1; j < n; j++)
            {
                if (tablica[j] < tablica[indeksMinimum])
                {
                    indeksMinimum = j;
                }
            }

            if (indeksMinimum != i)
            {
                int temp = tablica[i];
                tablica[i] = tablica[indeksMinimum];
                tablica[indeksMinimum] = temp;
            }
        }
    }
}