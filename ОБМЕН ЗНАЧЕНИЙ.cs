using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swaper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи два числа чтобы поменять их местами");
            int x = int.Parse(Console.ReadLine()), y = int.Parse(Console.ReadLine());
            Console.WriteLine("x={0}", x);
            Console.WriteLine("y={0}", y);

            int temp = y;
            y = x;
            x = temp;
            Console.WriteLine("ЧЕРЕЗ 3 ПЕРЕМЕННУЮ");
            Console.WriteLine("x={0}", x);
            Console.WriteLine("y={0}", y);

            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("БЕЗ 3 ПЕРЕМЕННОЙ");
            Console.WriteLine("x={0}", x);
            Console.WriteLine("y={0}", y);

        

            Console.ReadKey();
        }
    }
}
