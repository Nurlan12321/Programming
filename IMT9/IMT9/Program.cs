using System;

namespace IMT9
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Ros, Ves, IMT;
            Console.WriteLine("Введите рост");
            Ros = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вес");
            Ves = Convert.ToDouble(Console.ReadLine());
            IMT = Ves / Ros;
            Console.WriteLine(IMT);
            Console.ReadKey();
        }
    }
}
