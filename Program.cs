using System;

namespace ConsoleApp1
{
    class Program
    {
        static int[] Kopiowanie(int[] tablica) // Funkcja kopiujaca tablice
        {
            int[] nowaTablica = new int[tablica.Length];
            for (int i = 0; i < tablica.Length; i++)
            {
                nowaTablica[i] = tablica[i];
            }

            return nowaTablica;
        }

        static void Main(string[] args)
        {
            int[][] tablica =
            {
                new[] {1, 3, 7, 3 },
                new[] {2 },
                new[] {12, 5, 8, 3, 1, 4, 6, 3 }
            };
            int[][] nowaTablica = new int[tablica.Length][];

            // Kopiowanie
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                nowaTablica[i] = Kopiowanie(tablica[i]);
            }


            // Wypisywanie tablicy
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                foreach (var item in tablica[i])
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }

            Console.WriteLine("skopiowana: ");

            // Wypisywanie skopiowanej tablicy
            for (int i = 0; i < nowaTablica.GetLength(0); i++)
            {
                foreach (var item in nowaTablica[i])
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }



            //int[,] tablica =
            //    {
            //        { 1, 2, 3, 4, 5 },
            //        { 1, 2, 3, 4, 5 },
            //        { 1, 2, 3, 4, 5 },
            //        { 1, 2, 3, 4, 5 },
            //        { 1, 2, 3, 4, 5 }
            //    };


            //int[,] nowaTablica = new int[tablica.GetLength(0), tablica.GetLength(1)];

            //for (int i = 0; i < tablica.GetLength(0); i++)
            //{
            //    for (int j = 0; j < tablica.GetLength(1); j++)
            //    {
            //    nowaTablica[i,j] = tablica[i,j];
            //    }
            //}
            //nowaTablica[3,3] = 10;

            //foreach (var liczba in tablica)
            //{
            //    Console.Write(liczba + " ");
            //}
            //Console.WriteLine();
            //foreach (var liczba in nowaTablica)
            //{
            //    Console.Write(liczba + " ");
            //}

        }
    }
}
