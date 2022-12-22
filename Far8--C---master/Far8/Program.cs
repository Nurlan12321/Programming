using System;

namespace Far8
{
    class Program
    {
        static void Main(string[] args)
        {
            Double A,B;
            B = 0;
            try
            {
                Console.WriteLine("Введите число");
                A = Convert.ToDouble(Console.ReadLine());
                B = (A - 32) * 5 / 9;
            }
            catch
            {
                Console.WriteLine("Введите число");
                Console.ReadKey();
            }
            Console.WriteLine($"{B}°C");
            Console.ReadKey();
        }
    }
}
