using System;
using System.Linq;

namespace Mass4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] k = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 22 };
            int mass;
            mass = k.Min();
            Console.WriteLine(mass);
            Console.ReadLine();
        }
    }
}
