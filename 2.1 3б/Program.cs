using System;

namespace _2._1_3б
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            Console.WriteLine("Введите число X");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число");
            double y = double.Parse(Console.ReadLine());
            bool v = x >= 2;
            bool v1 = Math.Pow(y, 2) != 5;
            bool v2 = v != v1;
            //(x >= 2) != (Math.Pow(y, 2) != 5);
            Console.WriteLine("Ответ:" + v2);


        }
    }
}
