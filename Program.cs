using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, x, y;
            double s;

            Console.WriteLine("Введите количество точек N: ");
            N = int.Parse(Console.ReadLine());
            int xmax = 0; int ymax = 0;

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Введите точку x: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите точку y: ");
                y = int.Parse(Console.ReadLine());

                if ((x == 0) && (Math.Abs(y) > ymax)) { ymax = Math.Abs(y); }
                if ((y == 0) && (Math.Abs(x) > xmax)) { xmax = Math.Abs(x); }
            }
            s = xmax * ymax / 2;
            if (s == 0)
            {
                Console.WriteLine("Треугольник не существует");
            }
            else { Console.WriteLine(s); }
            Console.ReadKey();
        }
    }
}
