using System;
using System.Linq;

namespace SUMM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((101 + 0) / 3);
            Console.WriteLine(3.0e-6 * 10000000.1);
            Console.WriteLine(true && true);
            Console.WriteLine(false && true);
            Console.WriteLine((false && false)&&(true && true));
            Console.WriteLine((false&& false) && (true && true));
            Console.ReadKey();
        }
    }
}
