using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mass_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] k = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 22 };
            int sum =0;
        for (int i =0; i<k.Length; i++)
                sum += k[i];
        int sred = sum / k.Length;
            for (int ar = 0; ar < 14; ar++)
            {
                if (k[ar] > sred)
                {
                    Console.WriteLine(k[ar]);

                }
            }
            Console.ReadLine();



        }
    }
}
