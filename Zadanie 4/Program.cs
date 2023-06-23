using System;

class Program
{
    static void Main()
    {
        Console.Title = "Zadanie 4";

        Console.WriteLine("Algorytm do sortowania przez wstawianie");
        Console.WriteLine();

        int[] tablica = new int[10];
        Random losowaLiczba = new Random();

        for (int i = 0; i < tablica.Length; i++)
        {
            tablica[i] = losowaLiczba.Next(1, 100);
        }

        Console.WriteLine("Nieposortowana tablica:");
        WyswietlTablice(tablica);

        SortowanieWstawianie(tablica);

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

    static void SortowanieWstawianie(int[] tablica)
    {
        for (int i = 1; i < tablica.Length; i++)
        {
            int klucz = tablica[i];
            int j = i - 1;

            while (j >= 0 && tablica[j] > klucz)
            {
                tablica[j + 1] = tablica[j];
                j--;
            }

            tablica[j + 1] = klucz;
        }
    }
}