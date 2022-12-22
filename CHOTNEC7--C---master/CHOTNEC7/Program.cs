using System;

namespace CHOTNEC7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] k = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 22 };
            int[] n = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 22 };
            for (int i = 0; i < 14; i++)
            {
                if (k[i] % 2 == 1)
                    Console.WriteLine($"Нечтёные числа " + k[i]);
            }
            for (int i = 0; i < 14; i++)
            {
                if (n[i] % 2 == 0)
                    Console.WriteLine($"Чтёные числа " + n[i]);
            }
            Console.ReadKey();
        }
    }
}
